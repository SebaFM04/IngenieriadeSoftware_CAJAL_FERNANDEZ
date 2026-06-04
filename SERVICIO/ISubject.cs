using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO
{
    public interface ISubject
    {
        void Suscribir(IObserver observador);
        void Desuscribir(IObserver observador);
        void Notificar();
    }
}
