using DAL;
using SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IDIOMA_BLL
    {
        MAPPER_IDIOMA GestorIdioma = new MAPPER_IDIOMA();

        public List<BE.IDIOMA> ListarDisponibles()
        {
            return GestorIdioma.ListarDisponibles();
        }

        public void AgregarIdioma(BE.IDIOMA idioma)
        {
            GestorIdioma.AltaIdioma(idioma);
            new BITACORA_BLL().RegistrarEvento(
                SessionManager.Instancia.UsuarioActual.IdUsuario,
                "Alta de idioma",
                $"Se agregó el idioma: {idioma.Nombre}");
        }

        public void ModificarIdioma(BE.IDIOMA idioma)
        {
            GestorIdioma.ModificarIdioma(idioma);
            new BITACORA_BLL().RegistrarEvento(
                SessionManager.Instancia.UsuarioActual.IdUsuario,
                "Modificación de idioma",
                $"Se modificó el idioma: {idioma.Nombre}");
        }

        public void EliminarIdioma(BE.IDIOMA idioma)
        {
            GestorIdioma.BajaIdioma(idioma);
            new BITACORA_BLL().RegistrarEvento(
                SessionManager.Instancia.UsuarioActual.IdUsuario,
                "Baja de idioma",
                $"Se eliminó el idioma: {idioma.Nombre}");
        }
    }
}
