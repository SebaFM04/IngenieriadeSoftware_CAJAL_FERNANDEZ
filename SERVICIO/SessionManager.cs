using BE;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO
{
    public class SessionManager
    {

        private static SessionManager _instancia;
        private Sesion _sesion;

        private SessionManager()
        {
            _sesion = new Sesion();
        }

        public static SessionManager Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new SessionManager();
                return _instancia;
            }
        }

        public void Login(USUARIO usuario)
        {
            _sesion.Login(usuario);
        }

        public void Logout()
        {
            _sesion.Logout();
        }

        public bool IsLogged()
        {
            return _sesion.IsLogged();
        }

        public USUARIO UsuarioActual => _sesion.UsuarioLogueado;


        /*
        //Esto que parece 
        public bool IsLogged(BE.USUARIO usuario)
        {
            // Si no se pasa usuario, devolvemos si hay una sesión activa.
            if (usuario == null)
            {
                return this.sesionActual != null;
            }

            // Si se pide comprobar un usuario pero no hay sesión, no está logueado.
            if (this.sesionActual == null || this.sesionActual.Usuario == null) return false;

            var sesionUsuario = this.sesionActual.Usuario;

            // Comparar por Id cuando esté disponible, si no por correo (ignorar mayúsculas/minúsculas).
            if (sesionUsuario.IdUsuario != 0 && usuario.IdUsuario != 0)
            {
                return sesionUsuario.IdUsuario == usuario.IdUsuario;
            }

            return string.Equals(
                sesionUsuario.CorreoElectronico?.Trim(),
                usuario.CorreoElectronico?.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }
        */


    }
}
