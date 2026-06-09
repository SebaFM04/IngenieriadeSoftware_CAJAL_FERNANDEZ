using SERVICIO.MultiIdioma_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class GestorUI
    {
        private static GestorUI _instancia;
        public static GestorUI Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorUI();
                return _instancia;
            }
        }

        public void AbrirForm(Form form)
        {
            GestorIdioma.Instancia.Suscribir(form as IObservadorIdioma);
            form.ShowDialog();
            GestorIdioma.Instancia.Desuscribir(form as IObservadorIdioma);
        }
    }
}
