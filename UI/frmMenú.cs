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
            SERVICIO.SessionManager Sesion = SERVICIO.SessionManager.GetInstance();
            label1.Text = $"Bienvenido {Sesion.sesionActual.Usuario.CorreoElectronico}\n {Sesion.sesionActual.Usuario.NombreUsuario} {Sesion.sesionActual.Usuario.ApellidoUsuario}";
        }
        private void btnCerrarSesionfrmMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SERVICIO.SessionManager.GetInstance().Logout();
                this.Close();
            }
        }

        private void formularioUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.MdiParent = MdiParent;
            frmUsuario.Show();
        }
    }
}
