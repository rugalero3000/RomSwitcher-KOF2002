using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3K.KOF2002.RomSwitcher
{
  public partial class FrmLoader : Form
  {
    private static readonly string directoryRomsDefault = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Fightcade", "emulator", "fbneo", "ROMs");
    private string directoryRomsOriginal = Path.Combine(directoryRomsDefault, "kof2002_original");
    private string directoryRomsVerde = Path.Combine(directoryRomsDefault, "kof2002_verde");
    private string kof2002RomNameDefault = "kof2002.zip";
    private string kof2002PlusRomNameDefault = "kf2k2pls.zip";
    private string kof2002VerdeRomNameDefault = "kof2002.zip";
    private string kof2002PlusVerdeRomNameDefault = "kf2k2pls_verde.zip";
    public FrmLoader()
    {
      InitializeComponent();
    }

    private void FrmLoader_Load(object sender, EventArgs e)
    {
      Cargando();
    }

    private void Cargando()
    {
      Console.WriteLine("Cargando...");
      VerificarKofVerde();
    }

    private void VerificarKofVerde()
    {
      VerificarKof2002Verde();
      VerificarKof2002PlusVerde();
    }
    private void VerificarKof2002Verde()
    {
      string kof2002VerdePath = Path.Combine(directoryRomsVerde, kof2002VerdeRomNameDefault);
      if (File.Exists(kof2002VerdePath))
      {
        Console.WriteLine("KOF 2002 Verde encontrado.");
        return;
      }
      string kof2002VerdePathDefault = Path.Combine(directoryRomsDefault, kof2002VerdeRomNameDefault);
      if (File.Exists(kof2002VerdePathDefault))
      {
        Console.WriteLine("KOF 2002 Verde encontrado.");
        return;
      }
    }
    private void VerificarKof2002PlusVerde()
    {
      string kof2002PlusVerdePath = Path.Combine(directoryRomsDefault, kof2002PlusRomNameDefault);
      if(File.Exists(kof2002PlusVerdePath) == false)
      {

      }
      //{
      //  Console.WriteLine("KOF 2002 Plus Verde encontrado.");
      //  string kof2002PlusPath = Path.Combine(directoryRomsDefault, kof2002PlusVerdeRomNameDefault);
      //  if (File.Exists(kof2002PlusPath))
      //  {
      //    Console.WriteLine("KOF 2002 Plus original encontrado. Renombrando...");
      //    File.Move(kof2002PlusPath, Path.Combine(directoryRomsDefault, "kf2k2pls_backup.zip"));
      //  }
      //  Console.WriteLine("Renombrando KOF 2002 Plus Verde a KOF 2002 Plus original...");
      //  File.Move(kof2002PlusVerdePath, kof2002PlusPath);
      //  Console.WriteLine("Renombrado completado.");
      //}
      //else
      //{
      //  Console.WriteLine("KOF 2002 Plus Verde no encontrado.");
      //}
    }


  }
}
