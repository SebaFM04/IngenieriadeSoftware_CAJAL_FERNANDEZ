using DAL;
using SERVICIO;
using SERVICIO.MultiIdioma_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IDIOMA_BLL
    {
        private readonly MAPPER_IDIOMA _mapper = new MAPPER_IDIOMA();

        /// <summary>
        /// Devuelve la lista de idiomas disponibles para poblar combos.
        /// </summary>
        public List<IDIOMA> ListarIdiomas()
        {
            return _mapper.ListarIdiomas();
        }

        /// <summary>
        /// Carga las traducciones del idioma indicado desde la BD,
        /// se las entrega a GestorIdioma y éste notifica a todos los
        /// formularios suscritos.
        /// Si el usuario tiene sesión activa, también persiste su preferencia.
        /// </summary>
        public void CambiarIdioma(int idIdioma)
        {
            Dictionary<string, string> traducciones = _mapper.ObtenerTraducciones(idIdioma);
            GestorIdioma.Instancia.CambiarIdioma(idIdioma, traducciones);

            // Persistir preferencia del usuario logueado (si hay sesión)
            if (SessionManager.Instancia.IsLogged())
            {
                int idUsuario = SessionManager.Instancia.UsuarioActual.IdUsuario;
                _mapper.ActualizarIdiomaUsuario(idUsuario, idIdioma);
            }
        }

        /// <summary>
        /// Inicializa el idioma al arrancar la sesión: usa la preferencia
        /// guardada del usuario; si no tiene (NULL), usa Español (id=1).
        /// </summary>
        public void InicializarIdiomaUsuario(int? idIdioma)
        {
            int id = (idIdioma.HasValue && idIdioma.Value > 0) ? idIdioma.Value : 1;
            Dictionary<string, string> traducciones = _mapper.ObtenerTraducciones(id);
            GestorIdioma.Instancia.CambiarIdioma(id, traducciones);
        }
    }
}
