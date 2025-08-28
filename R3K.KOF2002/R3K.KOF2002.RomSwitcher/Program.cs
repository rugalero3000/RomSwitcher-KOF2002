using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3K.KOF2002.RomSwitcher
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new FrmLoader());

      // Mostrar el Loader primero
      using (var loader = new FrmLoader())
      {
        loader.ShowDialog();  // se queda aquí hasta que el Loader se cierre
      }

      // Luego abrir el formulario principal
      Application.Run(new FrmMain());
    }
  }
}
