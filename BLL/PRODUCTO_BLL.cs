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
        DIGITOVERIFICADOR_BLL dvBLL = new DIGITOVERIFICADOR_BLL();

        public void InsertarProducto(BE.PRODUCTO producto)
        {
            producto.DVH = dvBLL.CalcularDVH(producto);
            GestorProducto.AltaProducto(producto);
            dvBLL.RecalcularDV();
            new BITACORA_BLL().RegistrarEvento(SessionManager.Instancia.UsuarioActual.IdUsuario, "Alta de producto", $"Se agrego el producto: {producto.NombreProducto}");
        }

        public int EliminarProducto(BE.PRODUCTO producto)
        {
            int filas = GestorProducto.BajaProducto(producto);
            try
            {
                dvBLL.RecalcularDV();
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

        public int ModificarProducto(BE.PRODUCTO producto)
        {
            producto.DVH = dvBLL.CalcularDVH(producto);
            int filas = GestorProducto.EditarProducto(producto);
            try
            {
                dvBLL.RecalcularDV();
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

        public List<BE.PRODUCTO> ListarProductos()
        {
            return GestorProducto.ListarProductos();
        }
        public List<string> VerificarIntegridad()
        {
            return dvBLL.VerificarIntegridad();
        }

        public void RecalcularDV()
        {
            dvBLL.RecalcularDV();
        }
    }
}
