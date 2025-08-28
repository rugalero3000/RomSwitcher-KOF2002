using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace R3K.KOF2002.RomSwitcher
{
  public partial class FrmLoader : Form
  {
    private static readonly string directoryRomsDefault = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Fightcade", "emulator", "fbneo", "ROMs");
    private string directoryRomsOriginal = Path.Combine(directoryRomsDefault, "kof2002_original");
    private string directoryRomsVerde = Path.Combine(directoryRomsDefault, "kof2002_verde");
    private string kof2002RomNameDefault = "kof2002.zip";
    private string kof2002PlusRomNameDefault = "kf2k2pls.zip";
    private string kof2002VerdeRomNameDefault = "kof2002_verde.zip";
    private string kof2002PlusVerdeRomNameDefault = "kf2k2pls_verde.zip";

    private const string kof2002_original_hash = "870204ac21027c010de7a70da00da2202bb710a16f7c01b9b11ab680fe5c2c51";
    private const string kf2k2pls_original_hash = "9a7b976a47e4153a6c10be679b445b6b628fafc53b0c264947d48d0240bd90ea";

    private const string kof2002_verde_hash = "ce6f101a2f1d33c56d7f4a44b4a5e168894ba37a897aace43dabbc60dae87685";
    private const string kf2k2pls_verde_hash = "f9fda0ab66f0d63647f80985ca9363e0dc6582dfef3edc58ad238610502df8de";

    private Dictionary<string, string> romHashes = new Dictionary<string, string>
        {
            { "kof2002_original", kof2002_original_hash },
            { "kf2k2pls_original", kf2k2pls_original_hash },
            { "kof2002_verde", kof2002_verde_hash },
            { "kf2k2pls_verde", kf2k2pls_verde_hash }
        };
    List<ROM> romList = new List<ROM>();
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
      ValidarBaseROMsCrearCarpetas();
      VerificarKofVerde();
    }

    private void ValidarBaseROMsCrearCarpetas()
    {
      string biosPath = Path.Combine(directoryRomsDefault, "neogeo.zip");
      if(File.Exists(biosPath) == false)
      {
        MessageBox.Show("No se encontró el archivo neogeo.zip en la carpeta de ROMs. Por favor, asegúrate de que el archivo esté presente.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Environment.Exit(0);
      }
      CrearCarpetas();
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
        Console.WriteLine("KOF 2002 Verde encontrado. No hacer nada");
        return;
      }
      string kof2002VerdePathDefault = Path.Combine(directoryRomsDefault, kof2002VerdeRomNameDefault);
      if (File.Exists(kof2002VerdePathDefault))
      {
        Console.WriteLine("KOF 2002 Verde encontrado. Mover a carpeta kof2002_verde");
        CrearCarpetaKofVerde();
        string kof2002VerdeDestinoPath = Path.Combine(directoryRomsDefault, "kof2002_verde", kof2002RomNameDefault);
        File.Move(kof2002VerdePathDefault, kof2002VerdeDestinoPath);
        return;
      }

      if (romList.Count == 0)
      {
        var archivos = Directory.GetFiles(directoryRomsDefault, "*.zip");

        foreach (var archivo in archivos)
        {
          string hash = CalcularSHA256(archivo);

          foreach (var kvp in romHashes)
          {
            ROM rom = null;
            if (hash.Equals(kvp.Value, StringComparison.OrdinalIgnoreCase))
            {
              //Console.WriteLine($"Encontrado: {kvp.Key} en archivo {Path.GetFileName(archivo)}");
              rom = new ROM()
              {
                Tag = kvp.Key,
                Hash = hash,
                FileName = Path.GetFileName(archivo)
              };
              romList.Add(rom);
            }
          }
        }
      }
      var romKofVerdeItem = romList.Where(x => x.Hash == kof2002_verde_hash).FirstOrDefault();
      if(romKofVerdeItem != null)
      {
        Console.WriteLine("KOF 2002 Verde encontrado. Mover a carpeta kof2002_verde");
        CrearCarpetaKofVerde();
        string romverdePath = Path.Combine(directoryRomsDefault, romKofVerdeItem.FileName);
        string kof2002VerdeDestinoPath = Path.Combine(directoryRomsDefault, "kof2002_verde", kof2002RomNameDefault);
        File.Move(romverdePath, kof2002VerdeDestinoPath);
        return;
      }

      //TODO: no encontrado, especificar ruta base ROM
    }
    private void CrearCarpetas()
    {
      CrearCarpetaKofVerde();
      CrearCarpetaKofOriginal();
    }
    private void CrearCarpetaKofVerde()
    {
      string destino = Path.Combine(directoryRomsDefault, "kof2002_verde");
      Directory.CreateDirectory(destino);
    }

    private void CrearCarpetaKofOriginal()
    {
      string destino = Path.Combine(directoryRomsDefault, "kof2002_original");
      Directory.CreateDirectory(destino);
    }

    private string CalcularSHA256(string filePath)
    {
      using (var sha256 = SHA256.Create())
      using (var stream = File.OpenRead(filePath))
      {
        byte[] hashBytes = sha256.ComputeHash(stream);
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
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
