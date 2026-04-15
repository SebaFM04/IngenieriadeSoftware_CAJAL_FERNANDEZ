using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class USUARIO
    {

        private int idusuario;
        public int IdUsuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        private string nombreUsuario;
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private string apellidoUsuario;
        public string ApellidoUsuario
        {
            get { return apellidoUsuario; }
            set { apellidoUsuario = value; }
        }

        private int dni;
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string correoElectronico;
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        private string contraseñaUsuario;
        public string ContraseñaUsuario
        {
            get { return contraseñaUsuario; }
            set { contraseñaUsuario = value; }
        }

        private string rol;
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public static List<USUARIO> listaUsuarios = new List<USUARIO>();
        
        public override string ToString()
        {
            return IdUsuario.ToString();
        }
    }
}
