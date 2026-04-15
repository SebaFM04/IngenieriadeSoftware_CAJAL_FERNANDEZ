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

        public BE.USUARIO ConfirmarLogueo(BE.USUARIO usuario)
        {
            return GestorUsuario.ValidarUsuario(usuario);
        }

        public void RegistrarUsuario(BE.USUARIO usuario)
        {
            GestorUsuario.RegistrarUsuario(usuario);
        }

        /*A IMPLEMENTAR LlamarListado
        public List<BE.USUARIO> LlamarListado()
        {
            return GestorUsuario.ListarUsuarios();
        }
        */

    }
}
