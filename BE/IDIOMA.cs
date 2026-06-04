using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IDIOMA
    {

        private int idIdioma;

        public int IdIdioma {
            get { return idIdioma; }
            set { idIdioma = value; }
        }
        private string nombre;
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        private bool isDisponible;
        public bool IsDisponible {
            get { return isDisponible; }
            set { isDisponible = value; }
        }

        public override string ToString() => Nombre; // para que el ComboBox muestre el nombre

    }
}
