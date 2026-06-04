using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TRADUCCION
    {
        private int idTraduccion;
        public int IdTraduccion {
            get { return idTraduccion; }
            set { idTraduccion = value; }
        }

        private int idControl;
        public int IdControl {
            get { return idControl; }
            set { idControl = value; }
        }

        private int idIdioma;
        public int IdIdioma {
            get { return idIdioma; }
            set { idIdioma = value; }
        }

        private string textoTraducido;
        public string TextoTraducido {
            get { return textoTraducido; }
            set { textoTraducido = value; }
        }

        // Campos de la tabla Control (para mostrar en el abm de traducciones)

       private string nombreControl;
        public string NombreControl {
            get { return nombreControl; }
            set { nombreControl = value; }
        }

        private string nombreFormulario;
        public string NombreFormulario {
            get { return nombreFormulario; }
            set { nombreFormulario = value; }
        }
    }
}
