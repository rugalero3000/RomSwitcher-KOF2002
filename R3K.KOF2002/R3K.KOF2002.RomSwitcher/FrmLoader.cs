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
      progressBar1.Value = 5;
      Util.GetBaseRomPath();
      progressBar1.Value = 20;
      ValidarBaseROMsCrearCarpetas();
      progressBar1.Value = 40;
      VerificarRomsKof();
      progressBar1.Value = 100;
      MostrarMainForm();
    }
    private void MostrarMainForm()
    {
      //FrmMain mainForm = new FrmMain();
      //mainForm.FormClosed += (s, args) => this.Close();
      //mainForm.Show();
      //this.Hide(); // oculta el loader
      this.Close(); // cierra el loader
    }

    private void ValidarBaseROMsCrearCarpetas()
    {
      string biosPath = Path.Combine(Util.GetBaseRomPath(), "neogeo.zip");
      if (File.Exists(biosPath) == false)
      {
        DialogResult result = MessageBox.Show(
            "No se encontró el archivo 'neogeo.zip' en la carpeta de ROMs por defecto.\n\n¿Desea seleccionar manualmente la carpeta base de ROMs?",
            "Carpeta ROMs no encontrada",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result != DialogResult.Yes)
        {
          Console.WriteLine("Carpeta no seleccionada");
          MessageBox.Show("No ha seleccionado una carpeta. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          Environment.Exit(0);
          return;
        }

        using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
        {
          folderDialog.Description = "Seleccione la carpeta base de ROMs (debe contener 'neogeo.zip')";
          if (folderDialog.ShowDialog() != DialogResult.OK)
          {
            MessageBox.Show("No ha seleccionado una carpeta. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
            return;
          }

          string newPath = Path.Combine(folderDialog.SelectedPath, "neogeo.zip");
          if (File.Exists(newPath) == false)
          {
            MessageBox.Show("La carpeta seleccionada no contiene 'neogeo.zip'. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
            return;
          }
          Util.SaveBaseRomPath(folderDialog.SelectedPath);
          CrearCarpetas();
          return;
        }
      }
      CrearCarpetas();
    }

    private void VerificarRomsKof()
    {
      VerificarKof(Util.GetBaseRomPath(), "kof2002_verde", "kof2002.zip", "kof2002_verde.zip");
      VerificarKof(Util.GetBaseRomPath(), "kof2002_verde", "kf2k2pls.zip", "kf2k2pls_verde.zip");
      VerificarKof(Util.GetBaseRomPath(), "kof2002_original", "kof2002.zip", "kof2002.zip");
      VerificarKof(Util.GetBaseRomPath(), "kof2002_original", "kf2k2pls.zip", "kf2k2pls.zip");
      //VerificarKof2002PlusVerde();
    }
    private void VerificarKof(string rutaBaseRoms, string subCarpetaRoms, string primaryNameRom, string secondaryNameRom)
    {
      string kof2002VerdePath = Path.Combine(rutaBaseRoms, subCarpetaRoms, primaryNameRom);
      if (File.Exists(kof2002VerdePath))
      {
        Console.WriteLine("KOF 2002 Verde encontrado. No hacer nada");
        return;
      }
      string kof2002VerdePathDefault = Path.Combine(rutaBaseRoms, secondaryNameRom);
      if (File.Exists(kof2002VerdePathDefault))
      {
        Console.WriteLine("KOF 2002 Verde encontrado. Mover a carpeta kof2002_verde");
        string kof2002VerdeDestinoPath = Path.Combine(rutaBaseRoms, subCarpetaRoms, primaryNameRom);
        File.Move(kof2002VerdePathDefault, kof2002VerdeDestinoPath);
        return;
      }

      if (romList.Count == 0)
      {
        var archivos = Directory.GetFiles(rutaBaseRoms, "*.zip");

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

      ROM romKofVerdeItem = null;
      if (secondaryNameRom == "kof2002_verde.zip")
      {
        romKofVerdeItem = romList.Where(x => x.Hash == kof2002_verde_hash).FirstOrDefault();
      }
      else if (secondaryNameRom == "kf2k2pls_verde.zip")
      {
        romKofVerdeItem = romList.Where(x => x.Hash == kf2k2pls_verde_hash).FirstOrDefault();
      }
      else if (secondaryNameRom == "kof2002.zip")
      {
        romKofVerdeItem = romList.Where(x => x.Hash == kof2002_original_hash).FirstOrDefault();
      }
      else if (secondaryNameRom == "kf2k2pls.zip")
      {
        romKofVerdeItem = romList.Where(x => x.Hash == kf2k2pls_original_hash).FirstOrDefault();
      }

      if (romKofVerdeItem != null)
      {
        Console.WriteLine("KOF 2002 Verde encontrado. Mover a carpeta kof2002_verde");
        CrearCarpetaKofVerde();
        string romverdePath = Path.Combine(rutaBaseRoms, romKofVerdeItem.FileName);
        string kof2002VerdeDestinoPath = Path.Combine(rutaBaseRoms, subCarpetaRoms, primaryNameRom);
        File.Move(romverdePath, kof2002VerdeDestinoPath);
        return;
      }

      //TODO: no encontrado, especificar ruta base ROM
      MessageBox.Show($"No se ha encontrado la ROM {secondaryNameRom}. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      Environment.Exit(0);
    }
    private void CrearCarpetas()
    {
      CrearCarpetaKofVerde();
      CrearCarpetaKofOriginal();
    }
    private void CrearCarpetaKofVerde()
    {
      CrearCarpetaEnBaseRoms("kof2002_verde");
    }

    private void CrearCarpetaKofOriginal()
    {
      CrearCarpetaEnBaseRoms("kof2002_original");
    }
    private void CrearCarpetaEnBaseRoms(string nombreCarpeta)
    {
      string destino = Path.Combine(Util.GetBaseRomPath(), nombreCarpeta);
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
  }
}
