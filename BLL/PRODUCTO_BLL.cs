using BE;
using DAL;
using SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PRODUCTO_BLL
    {
        MAPPER_PRODUCTO GestorProducto = new MAPPER_PRODUCTO();

        public void AltaProducto(BE.PRODUCTO producto)
        {
            GestorProducto.InsertarProducto(producto);
            new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Alta de producto", $"Se agrego el producto: {producto.NombreProducto}");
        }

        public int BorrarProducto(BE.PRODUCTO producto)
        {
            int filas = GestorProducto.EliminarProducto(producto);
            try
            {
                if (SessionManager.Instancia != null && SessionManager.Instancia.IsLogged())
                {

                    new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Baja de producto", $"Se eliminó el producto: {producto.NombreProducto}");
                }
            }
            catch
            {
                // No interrumpir por fallos en bitácora
            }
            return filas;

        }

        public int EditarProducto(BE.PRODUCTO producto)
        {
            int filas = GestorProducto.ModificarProducto(producto);
            try
            {
                if (SessionManager.Instancia != null && SessionManager.Instancia.IsLogged())
                {

                    new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Modificación de producto", $"Se modificó el producto: {producto.NombreProducto}");
                }
            }
            catch
            {
                // No interrumpir por fallos en bitácora
            }
            return filas;
        }
    }
}
