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
        private static object _lock = new Object();
        private static SessionManager _instance;
        public Sesion sesionActual { get; private set; }

        public static SessionManager GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SessionManager();
                } 
                return _instance;
            }
        }

        public void Login(BE.USUARIO usuario)
        {
            this.sesionActual = new Sesion
            {
                Usuario = usuario,
                FechaInicio = DateTime.Now
            };
        }

        public void Logout()
        {
            this.sesionActual = null;
        }

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
        private SessionManager()
        {

        }
    }
}
