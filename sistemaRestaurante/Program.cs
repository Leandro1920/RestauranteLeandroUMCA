using sistemaRestaurante.modelo;
using sistemaRestaurante.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sistemaRestaurante
{
    static class Program
    {
      
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
