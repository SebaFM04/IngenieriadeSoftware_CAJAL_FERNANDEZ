using DAL;
using SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TRADUCCION_BLL
    {
        MAPPER_TRADUCCION GestorTraduccion = new MAPPER_TRADUCCION();

        public Dictionary<string, string> CargarTraducciones(int idIdioma)
        {
            return GestorTraduccion.ObtenerPorIdioma(idIdioma);
        }

        public List<BE.TRADUCCION> ListarPorIdioma(int idIdioma)
        {
            return GestorTraduccion.ListarPorIdioma(idIdioma);
        }

        public void AgregarTraduccion(BE.TRADUCCION traduccion)
        {
            GestorTraduccion.AltaTraduccion(traduccion);
            new BITACORA_BLL().RegistrarEvento(
                SessionManager.Instancia.UsuarioActual.IdUsuario,
                "Alta de traducción",
                $"Se agregó traducción para el control: {traduccion.NombreControl}");
        }

        public void ModificarTraduccion(BE.TRADUCCION traduccion)
        {
            GestorTraduccion.ModificarTraduccion(traduccion);
            new BITACORA_BLL().RegistrarEvento(
                SessionManager.Instancia.UsuarioActual.IdUsuario,
                "Modificación de traducción",
                $"Se modificó traducción para el control: {traduccion.NombreControl}");
        }

        public void EliminarTraduccion(BE.TRADUCCION traduccion)
        {
            GestorTraduccion.BajaTraduccion(traduccion);
            new BITACORA_BLL().RegistrarEvento(
                SessionManager.Instancia.UsuarioActual.IdUsuario,
                "Baja de traducción",
                $"Se eliminó traducción para el control: {traduccion.NombreControl}");
        }
    }
}
