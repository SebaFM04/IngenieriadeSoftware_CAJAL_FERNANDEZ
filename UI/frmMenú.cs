using BLL;
using SERVICIO;
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
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();            
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
            adminitraciónToolStripMenuItem.Visible = usuario.TienePermiso("Administracion");
            idiomaToolStripMenuItem.Visible = usuario.TienePermiso("Gestion Idiomas");
            backUpToolStripMenuItem.Visible = usuario.TienePermiso("BackUp");
        }

        private void btnCerrarSesionfrmMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLL.USUARIO_BLL Usuario = new BLL.USUARIO_BLL();
                Usuario.LogoutUsuario();
                this.Close();
            }
        }

        private void formularioUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.MdiParent = MdiParent;
            frmUsuario.ShowDialog();

            this.Show();    
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmBitacora frmBitacora = new frmBitacora();
            frmBitacora.MdiParent = MdiParent;
            frmBitacora.ShowDialog();

            this.Show();
        }

        private void formularioProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

            frmProducto frmProducto = new frmProducto();
            frmProducto.MdiParent = MdiParent;
            frmProducto.ShowDialog();

            this.Show();
        }

        private void admRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRolesyPermisos frmRolesyPermisos = new frmRolesyPermisos();
            frmRolesyPermisos.MdiParent = MdiParent;
            frmRolesyPermisos.ShowDialog();

            this.Show();
        }

        private void frmMenú_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }
    }
}
