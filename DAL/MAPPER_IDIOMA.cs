using SERVICIO.MultiIdioma_Observer;
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

        /// <summary>
        /// Devuelve todos los idiomas disponibles (IsDisponible = 1).
        /// </summary>
        public List<IDIOMA> ListarIdiomas()
        {
            var lista = new List<IDIOMA>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("ListarIdiomas");
            acceso.Cerrar();

            foreach (DataRow row in tabla.Rows)
            {
                lista.Add(new IDIOMA
                {
                    IdIdioma = Convert.ToInt32(row["IdIdioma"]),
                    Nombre = row["Nombre"].ToString(),
                    IsDisponible = Convert.ToBoolean(row["IsDisponible"])
                });
            }
            return lista;
        }

        /// <summary>
        /// Carga las traducciones para el idioma indicado.
        /// Clave del diccionario = NombreControl (igual que ctrl.Name en WinForms),
        /// igual al patrón del proyecto de referencia donde la clave es el nombre
        /// del control/etiqueta y el valor es el texto traducido.
        /// </summary>
        public Dictionary<string, string> ObtenerTraducciones(int idIdioma)
        {
            var traducciones = new Dictionary<string, string>();
            acceso.Abrir();

            var parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdIdioma", idIdioma)
            };
            DataTable tabla = acceso.Leer("ObtenerTraduccionesPorIdioma", parametros);
            acceso.Cerrar();

            foreach (DataRow row in tabla.Rows)
            {
                // Clave simple = NombreControl → igual que ctrl.Name
                // El SP ya filtra por idioma con fallback a Español
                string clave = row["NombreControl"].ToString();
                traducciones[clave] = row["TextoTraducido"].ToString();
            }
            return traducciones;
        }

        /// <summary>
        /// Persiste la preferencia de idioma del usuario en la BD.
        /// </summary>
        public void ActualizarIdiomaUsuario(int idUsuario, int idIdioma)
        {
            acceso.Abrir();
            var parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdUsuario", idUsuario),
                acceso.CrearParametro("@IdIdioma",  idIdioma)
            };
            acceso.Escribir("ActualizarIdiomaUsuario", parametros);
            acceso.Cerrar();
        }
    }
}
