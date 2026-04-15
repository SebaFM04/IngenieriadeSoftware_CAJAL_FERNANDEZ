using BLL;
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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuariofrmReg_Click(object sender, EventArgs e)
        {
            BE.USUARIO usuario = new BE.USUARIO();
            usuario.NombreUsuario = textBox1.Text;
            usuario.ApellidoUsuario = textBox2.Text;
            usuario.Dni = int.Parse(textBox3.Text);
            usuario.CorreoElectronico = textBox4.Text;
            usuario.ContraseñaUsuario = textBox5.Text;

            USUARIO_BLL GestorUsuario = new USUARIO_BLL();

            if (usuario != null)
            {
                GestorUsuario.RegistrarUsuario(usuario);
                MessageBox.Show("Usuario registrado exitosamente.");
                this.Close();
                frmLogin frmLog = new frmLogin();
                frmLog.MdiParent = MdiParent;
                frmLog.Show();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Verifique los datos ingresados.");
            }
        }

        private void llVolverLoginfrmReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            frmLogin frmLog = new frmLogin();
            frmLog.MdiParent = MdiParent;
            frmLog.Show();

            
        }
    }
}
