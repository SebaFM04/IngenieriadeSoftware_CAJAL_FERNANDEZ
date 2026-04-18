using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmLogin : Form
    {
        BE.USUARIO usuario = new BE.USUARIO();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btniniciarSesionfrmLogin_Click(object sender, EventArgs e)
        {
            try
            {
                #region VALIDACIONES DE CAMPOS
                // Validar que el nombre de usuario tenga formato de correo electrónico
                var email = textBox1.Text?.Trim();
                if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return; 
                }

                // Validar que se ingrese una contraseña
                var password = textBox2.Text ?? string.Empty;
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                #endregion


                BLL.USUARIO_BLL GestorUsuario = new BLL.USUARIO_BLL();

                usuario.CorreoElectronico = email;
                usuario.ContraseñaUsuario = textBox2.Text;

                BE.USUARIO UserfromBd = GestorUsuario.BuscarUsuarioEnBD(usuario);


                if (UserfromBd == null)
                {
                    MessageBox.Show("No existe el usuario ingresado.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Iniciar sesión y guardar el usuario en la sesión actual!!
                    SERVICIO.SessionManager.GetInstance().Login(UserfromBd);

                    MessageBox.Show("El usuario fue logueado exitosamente", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #region SALTO AL MENU PRINCIPAL
                    this.Hide();
                    frmMenú frmMenú = new frmMenú();
                    frmMenú.MdiParent = MdiParent;
                    frmMenú.ShowDialog();
                    this.Close();
                    #endregion  
                }

                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
