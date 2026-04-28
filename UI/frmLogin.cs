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
                if (!string.IsNullOrWhiteSpace(password) && password.Length < 4)
                {
                    MessageBox.Show("Ingrese una contraseña válida (Debe tener al menos 4 caracteres)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                #endregion

                BLL.USUARIO_BLL GestorUsuario = new BLL.USUARIO_BLL();
                // Iniciar sesión y guardar el usuario de la sesión actual!!
                BE.USUARIO UserfromBd = GestorUsuario.LoginUsuario(email, password);

                MessageBox.Show("El usuario fue logueado exitosamente", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #region SALTO AL MENU PRINCIPAL
                this.Hide();
                frmMenú frmMenú = new frmMenú();
                frmMenú.MdiParent = MdiParent;
                frmMenú.ShowDialog();
                this.Close();
                #endregion
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool oculto = true;
        private void btnMostrarContraseñafrmLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (oculto == true)
                {
                    textBox2.PasswordChar = '\0';
                    oculto = false;
                }
                else
                {
                    textBox2.PasswordChar = '*';
                    oculto = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
