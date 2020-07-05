using sistemacompra.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemacompra.vista.frmNuevos;
using sistemacompra.vista.frmPadres;
namespace sistemacompra
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vista.frmSecundarios.frmHistorialCompras());
        }
    }
}
