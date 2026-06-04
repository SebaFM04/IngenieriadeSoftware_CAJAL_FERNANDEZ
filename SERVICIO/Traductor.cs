using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO
{
    public class Traductor : ISubject
    {
        // ── Singleton ────────────────────────────────────────────
        private static Traductor _instancia;
        private static readonly object _lock = new object();

        public static Traductor ObtenerInstancia()
        {
            if (_instancia == null)
                lock (_lock)
                    if (_instancia == null)
                        _instancia = new Traductor();
            return _instancia;
        }

        private Traductor() { }

        // ── Estado ───────────────────────────────────────────────
        private List<IObserver> _observadores = new List<IObserver>();
        private Dictionary<string, string> _traducciones
            = new Dictionary<string, string>();

        public int IdiomaActual { get; private set; } = 1;

        // ── ISubject ─────────────────────────────────────────────
        public void Suscribir(IObserver observador)
        {
            if (!_observadores.Contains(observador))
                _observadores.Add(observador);
        }

        public void Desuscribir(IObserver observador)
        {
            _observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var obs in _observadores.ToArray())
                obs.ActualizarLenguaje();
        }

        // ── Comportamiento ───────────────────────────────────────
        public void ActualizarIdioma(int idIdioma)
        {
            IdiomaActual = idIdioma;
            _traducciones = new TRADUCCION_BLL().CargarTraducciones(idIdioma);
            Notificar();
        }

        public string Traducir(string formulario, string control)
        {
            string clave = $"{formulario}|{control}";
            return _traducciones.TryGetValue(clave, out string texto)
                ? texto
                : $"[{control}]";
        }
    }
}
