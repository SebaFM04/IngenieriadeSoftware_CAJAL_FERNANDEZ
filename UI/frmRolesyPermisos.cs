using BE;
using BLL;
using SERVICIO.MultiIdioma_Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmRolesyPermisos : Form, IObservadorIdioma
    {
        PERMISO_BLL permisoBLL = new PERMISO_BLL();
        USUARIO_BLL usuarioBLL = new USUARIO_BLL();
        public frmRolesyPermisos()
        {
            InitializeComponent();
        }

        private void frmRolesyPermisos_Load(object sender, EventArgs e)
        {
            ChBxfrmRolyPer.Checked = true;
            ChBxfrmRolyPer.Enabled = false;
            ChBxfrmRolyPer.Text = "Rol (siempre activo)";

            CargarComboRoles();
            CargarArbol();
            CargarPermisosDisponibles();
            CargarComboUsuarios();
            CargarComboRolAsignar();
        }

        private void CargarComboUsuarios()
        {
            comboBox2.Items.Clear();
            var usuarios = usuarioBLL.ListarUsuarios();
            foreach (var u in usuarios)
                comboBox2.Items.Add(u);
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }

        // ── Combo Rol a asignar ──────────────────────────────────
        private void CargarComboRolAsignar()
        {
            comboBox3.Items.Clear();
            var roles = permisoBLL.ObtenerPermisosCompuestosRaiz();
            foreach (var r in roles)
                comboBox3.Items.Add(r);
            if (comboBox3.Items.Count > 0)
                comboBox3.SelectedIndex = 0;
        }

        // ── Botón Asignar Rol ────────────────────────────────────
        private void btn6frmRolyPer_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario y un rol.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = (BE.USUARIO)comboBox2.SelectedItem;
            var rol = (PERMISOCOMPONENT)comboBox3.SelectedItem;

            try
            {
                permisoBLL.AsignarPermisoAUsuario(usuario.IdUsuario, rol.Id);
                MessageBox.Show(
                    $"Rol '{rol.NombrePermiso}' asignado a '{usuario.CorreoElectronico}' correctamente.",
                    "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetBaseException().Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboRoles()
        {
            comboBox1.Items.Clear();
            var roles = permisoBLL.ObtenerPermisosCompuestosRaiz();
            foreach (var r in roles)
            {
                comboBox1.Items.Add(r);
            }
               
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarArbol();
        }

        // ── TreeView izquierdo ───────────────────────────────────
        private void CargarArbol()
        {
            tVfrmRolyPer.Nodes.Clear();

            if (comboBox1.SelectedItem == null) return;

            var rolSeleccionado = (PERMISOCOMPONENT)comboBox1.SelectedItem;
            var arbol = permisoBLL.ObtenerPermisoConJerarquiaPorId(rolSeleccionado.Id);

            if (arbol != null)
            {
                tVfrmRolyPer.Nodes.Add(CrearNodo(arbol));
            }

            tVfrmRolyPer.ExpandAll();
        }

        private TreeNode CrearNodo(PERMISOCOMPONENT permiso)
        {
            var nodo = new TreeNode(permiso.NombrePermiso);
            nodo.Tag = permiso;
            foreach (var hijo in permiso.ListarPermisosHijos())
            {
                nodo.Nodes.Add(CrearNodo(hijo));
            }
            return nodo;
        }

        // ── ListBox derecho ──────────────────────────────────────
        private void CargarPermisosDisponibles()
        {
            lstfrmRolyPer.Items.Clear();
            var todos = permisoBLL.ObtenerTodosLosPermisos();
            foreach (var p in todos)
            {
                lstfrmRolyPer.Items.Add(p);
            }
        }

        // ── Selección en el TreeView → rellena TextBox ───────────
        private void tVfrmRolyPer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is PERMISOCOMPONENT p)
            {
                textBox1.Text = p.NombrePermiso;
                ChBxfrmRolyPer.Checked = p is PERMISOCOMPOSITE;
            }
        }

        // ── Botón Agregar ────────────────────────────────────────
        private void btn1frmRolyPer_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre para el permiso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool esFamilia = ChBxfrmRolyPer.Checked;

            try
            {
                permisoBLL.CrearPermiso(nombre, esFamilia);
                MessageBox.Show("Permiso agregado correctamente.", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Botón Modificar ──────────────────────────────────────
        private void btn2frmRolyPer_Click(object sender, EventArgs e)
        {
            if (tVfrmRolyPer.SelectedNode == null)
            {
                MessageBox.Show("Seleccione un permiso en el árbol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nuevo nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var permiso = (PERMISOCOMPONENT)tVfrmRolyPer.SelectedNode.Tag;
            bool esFamilia = permiso is PERMISOCOMPOSITE;

            try
            {
                permisoBLL.ModificarPermiso(permiso.Id, nombre, esFamilia);
                MessageBox.Show("Permiso modificado correctamente.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Botón Eliminar ───────────────────────────────────────
        private void btn3frmRolyPer_Click(object sender, EventArgs e)
        {
            if (tVfrmRolyPer.SelectedNode == null)
            {
                MessageBox.Show("Seleccione un permiso en el árbol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var permiso = (PERMISOCOMPONENT)tVfrmRolyPer.SelectedNode.Tag;
            var confirm = MessageBox.Show( $"¿Confirma eliminar el permiso '{permiso.NombrePermiso}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                permisoBLL.EliminarPermiso(permiso.Id);
                MessageBox.Show("Permiso eliminado correctamente.", "Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Botón Agregar Hijo ───────────────────────────────────
        private void btn4frmRolyPer_Click(object sender, EventArgs e)
        {
            if (tVfrmRolyPer.SelectedNode == null || lstfrmRolyPer.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un permiso padre en el árbol y un hijo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var padre = (PERMISOCOMPONENT)tVfrmRolyPer.SelectedNode.Tag;
            var hijo = (PERMISOCOMPONENT)lstfrmRolyPer.SelectedItem;

            try
            {
                permisoBLL.AgregarRelacion(padre.Id, hijo.Id);
                Refrescar();
            }
            catch (Exception ex)
            {
                // Muestra validaciones de la BLL (circular, no es composite, etc.)
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Botón Quitar Hijo ────────────────────────────────────
        private void btn5frmRolyPer_Click(object sender, EventArgs e)
        {
            if (tVfrmRolyPer.SelectedNode == null ||
                tVfrmRolyPer.SelectedNode.Parent == null)
            {
                MessageBox.Show("Seleccione un nodo hijo en el árbol (no la raíz).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hijo = (PERMISOCOMPONENT)tVfrmRolyPer.SelectedNode.Tag;
            var padre = (PERMISOCOMPONENT)tVfrmRolyPer.SelectedNode.Parent.Tag;

            try
            {
                permisoBLL.QuitarRelacion(padre.Id, hijo.Id);
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            CargarComboRoles();
            CargarArbol();
            CargarPermisosDisponibles();
            CargarComboRolAsignar();
        }

        private void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
            ChBxfrmRolyPer.Checked = true;//Siempre queda en TRUE
        }

        public void ActualizarIdioma()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is DataGridView || ctrl is ComboBox)
                    continue;
                ctrl.Text = GestorIdioma.Instancia.Traducir(ctrl.Name);
            }
        }
    }
}
