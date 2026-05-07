using BE;
using SERVICIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MAPPER_PRODUCTO
    {
        ACCESO acceso = new ACCESO();

        public int InsertarProducto(BE.PRODUCTO Producto)
        {
            string NombreSp = "AltaProducto";
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@Nombre", Producto.NombreProducto));
            parametros.Add(acceso.CrearParametro("@Precio", Producto.PrecioProducto.ToString()));
            parametros.Add(acceso.CrearParametro("@Tipo", Producto.TipoProducto));
            parametros.Add(acceso.CrearParametro("@Descripcion", Producto.Descripcion));
            parametros.Add(acceso.CrearParametro("@Cantidad", Producto.Cantidad.ToString()));
            parametros.Add(acceso.CrearParametro("@Codigo", Producto.CodigoProducto.ToString()));
            int filas = acceso.Escribir(NombreSp, parametros);
            acceso.Cerrar();
            return filas;
        }


        public int EliminarProducto(BE.PRODUCTO Producto)
        {
            string NombreSp = "BajaProducto";
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdProducto", Producto.IdProducto));
            int filas = acceso.Escribir(NombreSp, parametros);
            acceso.Cerrar();
            return filas;
        }

        public int ModificarProducto(BE.PRODUCTO Producto)
        {
            string NombreSp = "ModificarProducto";
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdProducto", Producto.IdProducto));
            parametros.Add(acceso.CrearParametro("@Nombre", Producto.NombreProducto));
            parametros.Add(acceso.CrearParametro("@Precio", Producto.PrecioProducto.ToString()));
            parametros.Add(acceso.CrearParametro("@Tipo", Producto.TipoProducto));
            parametros.Add(acceso.CrearParametro("@Descripcion", Producto.Descripcion));
            parametros.Add(acceso.CrearParametro("@Cantidad", Producto.Cantidad.ToString()));
            parametros.Add(acceso.CrearParametro("@Codigo", Producto.CodigoProducto.ToString()));
            int filas = acceso.Escribir(NombreSp, parametros);
            acceso.Cerrar();
            return filas;
        }
    }
}
