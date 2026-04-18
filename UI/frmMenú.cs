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
            SERVICIO.SessionManager.GetInstance().Logout();
            this.Close();
        }
    }
}
