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
    }
}
