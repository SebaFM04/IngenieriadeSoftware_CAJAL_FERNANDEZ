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
            SERVICIO.SessionManager session = SERVICIO.SessionManager.GetInstance;
            label1.Text = $"Bienvenido {session.Usuario.CorreoElectronico}\n {session.Usuario.NombreUsuario} {session.Usuario.ApellidoUsuario}";
        }
        private void btnCerrarSesionfrmMenu_Click(object sender, EventArgs e)
        {
            SERVICIO.SessionManager.Logout();
            this.Close();
        }
    }
}
