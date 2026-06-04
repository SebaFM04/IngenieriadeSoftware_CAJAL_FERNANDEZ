using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Verificar integridad ANTES del login
            var errores = new BLL.PRODUCTO_BLL().VerificarIntegridad();
            if (errores.Count > 0)
            {
                string mensaje = "Se detectaron errores de integridad:\n\n" +
                                 string.Join("\n", errores) +
                                 "\n\nContacte al administrador.";
                MessageBox.Show(mensaje, "Error de Integridad",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new frmLogin());
        }
    }
}
