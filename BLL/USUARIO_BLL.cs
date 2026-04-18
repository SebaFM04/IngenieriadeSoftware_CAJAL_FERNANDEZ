using DAL;
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

        public BE.USUARIO BuscarUsuarioEnBD(BE.USUARIO usuario)
        {
            return GestorUsuario.BuscarUsuario(usuario);
        }

        public void AltaUsuario(BE.USUARIO usuario)
        {
            GestorUsuario.RegistrarUsuario(usuario);
        }

        public void BorrarUsuario(BE.USUARIO usuario)
        {
            //GestorUsuario.EliminarUsuario(usuario);
        }

        public void EditarUsuario(BE.USUARIO usuario)
        {
            //GestorUsuario.ModificarUsuario(usuario);
        }

        /*A IMPLEMENTAR LlamarListado
        public List<BE.USUARIO> ListarUsuarios()
        {
            return GestorUsuario.LlamarListado();
        }
        */

    }
}
