using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MAPPER_TRADUCCION
    {
        ACCESO acceso = new ACCESO();

        // CARGA TODAS LAS TRADUCCIOENS EN UN DICCIONARIO Y LO DEVUELVE PARA QUE EL SERVICIO PUEDA USARLO PARA TRADUCIR LOS TEXTOS DE LOS CONTROLES
        public Dictionary<string, string> ObtenerPorIdioma(int idIdioma)
        {
            var dic = new Dictionary<string, string>();
            acceso.Abrir();
            var parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdIdioma", idIdioma)
            };
            DataTable tabla = acceso.Leer("ObtenerTraduccionesPorIdioma", parametros);
            acceso.Cerrar();

            foreach (DataRow row in tabla.Rows)
            {
                string clave = $"{row["NombreFormulario"]}|{row["NombreControl"]}";
                dic[clave] = row["TextoTraducido"].ToString();
            }
            return dic;
        }

        public List<BE.TRADUCCION> ListarPorIdioma(int idIdioma)
        {
            List<BE.TRADUCCION> lista = new List<BE.TRADUCCION>();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdIdioma", idIdioma));
            DataTable tabla = acceso.Leer("ListarTraduccionesPorIdioma", parametros);
            acceso.Cerrar();

            foreach (DataRow row in tabla.Rows)
            {
                BE.TRADUCCION traduccion = new BE.TRADUCCION();
                traduccion.IdTraduccion = Convert.ToInt32(row["IdTraduccion"]);
                traduccion.IdControl = Convert.ToInt32(row["IdControl"]);
                traduccion.IdIdioma = Convert.ToInt32(row["IdIdioma"]);
                traduccion.TextoTraducido = row["TextoTraducido"].ToString();
                traduccion.NombreControl = row["NombreControl"].ToString();
                traduccion.NombreFormulario = row["NombreFormulario"].ToString();
                lista.Add(traduccion);
            }
            return lista;
        }

        public int AltaTraduccion(BE.TRADUCCION traduccion)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdControl", traduccion.IdControl));
            parametros.Add(acceso.CrearParametro("@IdIdioma", traduccion.IdIdioma));
            parametros.Add(acceso.CrearParametro("@TextoTraducido", traduccion.TextoTraducido));
            int filas = acceso.Escribir("AltaTraduccion", parametros);
            acceso.Cerrar();
            return filas;
        }

        public int ModificarTraduccion(BE.TRADUCCION traduccion)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdTraduccion", traduccion.IdTraduccion));
            parametros.Add(acceso.CrearParametro("@TextoTraducido", traduccion.TextoTraducido));
            int filas = acceso.Escribir("ModificarTraduccion", parametros);
            acceso.Cerrar();
            return filas;
        }

        public int BajaTraduccion(BE.TRADUCCION traduccion)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdTraduccion", traduccion.IdTraduccion));
            int filas = acceso.Escribir("BajaTraduccion", parametros);
            acceso.Cerrar();
            return filas;
        }

    }
}
