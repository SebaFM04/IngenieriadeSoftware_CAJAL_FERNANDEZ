using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO.MultiIdioma_Observer
{
   
    // Interfaz Observer del patrón.
    // Los formularios que implementen esta interfaz son notificados por GestorIdioma cuando el usuario cambia de idioma.
    
    public interface IObservadorIdioma
    {

        void ActualizarIdioma();
    }
}
