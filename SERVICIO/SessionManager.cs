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

        private SessionManager()
        {

        }
    }
}
