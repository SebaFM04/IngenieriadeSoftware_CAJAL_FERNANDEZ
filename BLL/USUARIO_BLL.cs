using DAL;
using SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class USUARIO_BLL
    {
        MAPPER_USUARIO GestorUsuario = new MAPPER_USUARIO();
        
        public BE.USUARIO LoginUsuario(string Correo, string contraseña)
        {
            if (SessionManager.Instancia.IsLogged()) throw new Exception("Ya hay una sesión iniciada.");
            var user  = GestorUsuario.BuscarUsuario( Correo, contraseña );
            if (user == null) throw new Exception("Usuario no encontrado.");
            SessionManager.Instancia.Login(user);
            new BITACORA_BLL().RegistrarEvento(user.IdUsuario, "Inicio de sesion", $"Usuario: {user.CorreoElectronico}");
            return user;
        }

        public void LogoutUsuario(){
            var user = SessionManager.Instancia.UsuarioActual;
            SessionManager.Instancia.Logout();
            new BITACORA_BLL().RegistrarEvento(user.IdUsuario, "Cierre de sesion", $"El Usuario: {user.CorreoElectronico} Cerró la sesion.");
        }

        public void AltaUsuario(BE.USUARIO usuario)
        {
            GestorUsuario.RegistrarUsuario(usuario);
            new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Alta de usuario", $"Se agrego el usuario: {usuario.CorreoElectronico}");
        }

        public BE.USUARIO BuscarUsuarioEnBD(string Correo, string Contraseña)
        {
            return new MAPPER_USUARIO().BuscarUsuario(Correo, Contraseña);
        }

        public int BorrarUsuario(BE.USUARIO usuario)
        {
            int filas = GestorUsuario.EliminarUsuario(usuario);
            try
            {
                if (SessionManager.Instancia != null && SessionManager.Instancia.IsLogged())
                {
                    new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Baja de usuario", $"Se eliminó el usuario: {usuario.CorreoElectronico}");
                }
            }
            catch
            {
                // No interrumpir por fallos en bitácora
            }
            return filas;
        }

        public int EditarUsuario(BE.USUARIO usuario)
        {
            int filas = GestorUsuario.ModificarUsuario(usuario);
            try
            {
                if (SessionManager.Instancia != null && SessionManager.Instancia.IsLogged())
                {
                    new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Edición de usuario", $"Se modificó el usuario: {usuario.CorreoElectronico}");
                }
            }
            catch
            {
                // No interrumpir por fallos en bitácora
            }
            return filas;
        }

        public List<BE.USUARIO> ListarUsuarios()
        {
            return GestorUsuario.ListarUsuarios();
        }
        

    }
}
