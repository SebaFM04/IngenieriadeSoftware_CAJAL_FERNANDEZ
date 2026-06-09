using SERVICIO.MultiIdioma_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO.MultiIdioma_Observer
{
    /// <summary>
    /// Singleton + Subject del patrón Observer MultiIdioma.
    /// Análogo al "Traductor" del proyecto de ejemplo:
    ///   - Guarda el diccionario de traducciones del idioma activo.
    ///   - Expone Traducir(key) para que los forms puedan usarlo en ActualizarIdioma().
    ///   - Notifica a todos los observadores suscritos cuando cambia el idioma.
    /// </summary>
    public class GestorIdioma
    {
        // ── Singleton 
        private static GestorIdioma _instancia;
        public static GestorIdioma Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorIdioma();
                return _instancia;
            }
        }

        private GestorIdioma()
        {
            _idIdiomaActual = 1; // Español por defecto
            _traduccionesActuales = new Dictionary<string, string>();
            _observadores = new List<IObservadorIdioma>();
        }

        // ── Estado ────────────────────────────────────────────────
        private int _idIdiomaActual;
        private Dictionary<string, string> _traduccionesActuales;
        private readonly List<IObservadorIdioma> _observadores;

        public int IdIdiomaActual => _idIdiomaActual;

        // ── Traducción ────────────────────────────────────────────
        /// <summary>
        /// Devuelve el texto traducido para el nombre de control dado.
        /// Si no existe en el diccionario devuelve el mismo key
        /// (igual que el try/catch del ejemplo de referencia).
        /// </summary>
        public string Traducir(string nombreControl)
        {
            try { return _traduccionesActuales[nombreControl]; }
            catch { return nombreControl; }
        }

        // ── Gestión de observadores ───────────────────────────────
        /// <summary>
        /// Suscribe un form. Si ya hay traducciones cargadas,
        /// lo notifica de inmediato para que se muestre en el
        /// idioma correcto desde el primer render.
        /// (Igual que Suscribir + Notificar() del ejemplo.)
        /// </summary>
        public void Suscribir(IObservadorIdioma observador)
        {
            if (observador == null) return;
            if (!_observadores.Contains(observador))
                _observadores.Add(observador);

            // Notificación inmediata si ya hay traducciones
            if (_traduccionesActuales.Count > 0)
                observador.ActualizarIdioma();
        }

        public void Desuscribir(IObservadorIdioma observador)
        {
            if (observador != null)
                _observadores.Remove(observador);
        }

        // ── Cambio de idioma ──────────────────────────────────────
        /// <summary>
        /// Recibe el nuevo idioma y su diccionario desde IDIOMA_BLL,
        /// guarda el estado y notifica a todos los forms suscritos.
        /// </summary>
        public void CambiarIdioma(int idIdioma, Dictionary<string, string> traducciones)
        {
            _idIdiomaActual = idIdioma;
            _traduccionesActuales = traducciones ?? new Dictionary<string, string>();
            Notificar();
        }

        private void Notificar()
        {
            foreach (var obs in new List<IObservadorIdioma>(_observadores))
            {
                try { obs.ActualizarIdioma(); }
                catch { /* No interrumpir al resto si un form ya fue cerrado */ }
            }
        }
    }
}