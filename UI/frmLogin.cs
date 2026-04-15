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
                // Validar que el nombre de usuario tenga formato de correo electrónico
                var email = textBox1.Text?.Trim();
                if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido para el nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return; // No continuar con el inicio de sesión
                }

                // Validar que se ingrese una contraseña
                var password = textBox2.Text ?? string.Empty;
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }

                BLL.USUARIO_BLL GestorUsuario = new BLL.USUARIO_BLL();

                usuario.CorreoElectronico = email;
                usuario.ContraseñaUsuario = textBox2.Text;

                BE.USUARIO UserfromBd = GestorUsuario.ConfirmarLogueo(usuario);

                if (UserfromBd == null)
                {
                    MessageBox.Show("NO EXISTEN USUARIOS EN LA BASE DE DATOS", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UserfromBd.CorreoElectronico != usuario.CorreoElectronico && UserfromBd.ContraseñaUsuario != usuario.ContraseñaUsuario)
                {
                    MessageBox.Show("USUARIO NO COINCIDE CON LA BASE DE DATOS", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("El usuario fue logueado exitosamente", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llRegistresefrmLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frmReg = new frmRegistro();
            frmReg.MdiParent = MdiParent;            
            frmReg.Show();
        }
    }
}
