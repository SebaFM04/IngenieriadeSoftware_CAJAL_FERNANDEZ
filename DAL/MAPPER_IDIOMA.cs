using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MAPPER_IDIOMA
    {
        ACCESO acceso = new ACCESO();
        public List<IDIOMA> ListarDisponibles()
        {
            var lista = new List<IDIOMA>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("ListarIdiomasDisponibles");
            acceso.Cerrar();

            foreach (DataRow row in tabla.Rows)
            {
                lista.Add(new IDIOMA
                {
                    IdIdioma = (int)row["IdIdioma"],
                    Nombre = row["Nombre"].ToString()
                });
            }
            return lista;
        }
        public int AltaIdioma(BE.IDIOMA idioma)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@Nombre", idioma.Nombre));
            parametros.Add(acceso.CrearParametro("@IsDisponible", idioma.IsDisponible));
            int filas = acceso.Escribir("AltaIdioma", parametros);
            acceso.Cerrar();
            return filas;
        }

        public int ModificarIdioma(BE.IDIOMA idioma)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdIdioma", idioma.IdIdioma));
            parametros.Add(acceso.CrearParametro("@Nombre", idioma.Nombre));
            parametros.Add(acceso.CrearParametro("@IsDisponible", idioma.IsDisponible));
            int filas = acceso.Escribir("ModificarIdioma", parametros);
            acceso.Cerrar();
            return filas;
        }

        public int BajaIdioma(BE.IDIOMA idioma)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@IdIdioma", idioma.IdIdioma));
            int filas = acceso.Escribir("BajaIdioma", parametros);
            acceso.Cerrar();
            return filas;
        }
    }
}
