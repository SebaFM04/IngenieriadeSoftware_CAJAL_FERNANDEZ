using BLL;
using SERVICIO;
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
    public partial class frmMenú : Form, IObservadorIdioma
    {
        GestorUI gestorUI = GestorUI.Instancia;
        public frmMenú()
        {
            InitializeComponent();
            //ActualizarIdioma();
            SERVICIO.SessionManager Sesion = SERVICIO.SessionManager.Instancia;
            label1.Text = $"CorreoElectronico: {Sesion.UsuarioActual.CorreoElectronico}\nNombre y Apellido: {Sesion.UsuarioActual.NombreUsuario} {Sesion.UsuarioActual.ApellidoUsuario}";
        }
        private void AplicarPermisos()
        {
            var usuario = SERVICIO.SessionManager.Instancia.UsuarioActual;

            // Sin permisos asignados → muestra todo
            if (usuario.PermisosAsignados == null || usuario.PermisosAsignados.Count == 0)
                return;

            gestiónUsuariosToolStripMenuItem.Visible = usuario.TienePermiso("Gestion Usuarios");
            gestiónProductosToolStripMenuItem.Visible = usuario.TienePermiso("Gestion Productos");
            adminitraciónToolStripMenuItem.Visible = usuario.TienePermiso("Auditoria");
            idiomaToolStripMenuItem.Visible = usuario.TienePermiso("Gestion Idiomas");
            backUpToolStripMenuItem1.Visible = usuario.TienePermiso("BackUp");
            recalcularDVToolStripMenuItem.Visible = usuario.TienePermiso("Auditoria");
            controlCambiosToolStripMenuItem.Visible = usuario.TienePermiso("Auditoria");
        }

        private void btnCerrarSesionfrmMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new BLL.USUARIO_BLL().LogoutUsuario();
                this.Close();
            }
        }
        private void frmMenú_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        private void formularioUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gestorUI.AbrirForm(new frmUsuario());

            //this.Hide();

            //frmUsuario frmUsuario = new frmUsuario();
            //frmUsuario.MdiParent = MdiParent;
            //frmUsuario.ShowDialog();

            //this.Show();    
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestorUI.AbrirForm(new frmBitacora());
        }

        private void formularioProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestorUI.AbrirForm(new frmProducto());
        }

        private void admRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestorUI.AbrirForm(new frmRolesyPermisos());
        }


        private void backUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gestorUI.AbrirForm(new frmBackUp_Restore());

        }

        private void recalcularDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Confirma que desea recalcular los dígitos verificadores?", "Recalcular DV", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                new BLL.PRODUCTO_BLL().RecalcularDV();
                MessageBox.Show("Dígitos verificadores recalculados correctamente.", "Recalcular DV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recalcular: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void controlCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestorUI.AbrirForm(new frmControlCambios());
        }

        public void ActualizarIdioma()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is MenuStrip) continue;
                ctrl.Text = GestorIdioma.Instancia.Traducir(ctrl.Name);
            }

            foreach (ToolStripMenuItem item in mnstripMenu.Items)
                TraducirMenuItem(item);
        }

        private void TraducirMenuItem(ToolStripMenuItem item)
        {
            item.Text = GestorIdioma.Instancia.Traducir(item.Name);
            foreach (ToolStripMenuItem sub in item.DropDownItems.OfType<ToolStripMenuItem>())
                TraducirMenuItem(sub);
        }
    }
}
