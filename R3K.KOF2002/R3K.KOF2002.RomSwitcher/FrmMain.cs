using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
  public partial class FrmMain : Form
  {
    private const string kof2002_verde_hash = "ce6f101a2f1d33c56d7f4a44b4a5e168894ba37a897aace43dabbc60dae87685";
    private const string kf2k2pls_verde_hash = "f9fda0ab66f0d63647f80985ca9363e0dc6582dfef3edc58ad238610502df8de";
    public FrmMain()
    {
      InitializeComponent();
    }

    private void btnActivateOriginalKof2002_Click(object sender, EventArgs e)
    {
      try
      {
        ActivarRom(Util.GetBaseRomPath(), "kof2002_original", "kof2002.zip");
        ActivarRom(Util.GetBaseRomPath(), "kof2002_original", "kf2k2pls.zip");
        CargarTemaKofOriginal();
        MessageBox.Show("Activadas ROMs originales.");
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error al activar la ROM: {ex.Message}");
      }

    }

    private void btnActivateKof2002Green_Click(object sender, EventArgs e)
    {
      try
      {
        ActivarRom(Util.GetBaseRomPath(), "kof2002_verde", "kof2002.zip");
        ActivarRom(Util.GetBaseRomPath(), "kof2002_verde", "kf2k2pls.zip");
        CargarTemaKofVerde();
        MessageBox.Show("Activadas ROMs hack (verde).");
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error al activar la ROM: {ex.Message}");
      }

    }
    private void ActivarRom(string rutaBaseRoms, string subCarpeta, string romFilename)
    {
      try
      {
        string pathOrigen = Path.Combine(rutaBaseRoms, subCarpeta, romFilename);
        string pathDestino = Path.Combine(rutaBaseRoms, romFilename);

        if (File.Exists(pathDestino))
          File.Delete(pathDestino);

        File.Copy(pathOrigen, pathDestino);
      }
      catch (Exception ex)
      {
        //MessageBox.Show($"Error al activar la ROM: {ex.Message}");
        throw;
      }

    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      CargarTema();
      txtRutaBaseRoms.Text = Util.GetBaseRomPath();
    }

    private void CargarTema()
    {
      if (EsKofVerde())
      {
        CargarTemaKofVerde();
        return;
      }
      CargarTemaKofOriginal();
    }

    private bool EsKofVerde()
    {
      bool result = false;
      string kof2002Path = Path.Combine(Util.GetBaseRomPath(), "kof2002.zip");
      string kof2002PlusPath = Path.Combine(Util.GetBaseRomPath(), "kf2k2pls.zip");
      if(File.Exists(kof2002Path) && File.Exists(kof2002PlusPath))
      {
        var buscados = new[] { "kof2002.zip", "kf2k2pls.zip" };

        var archivos = buscados
            .Select(f => Path.Combine(Util.GetBaseRomPath(), f))
            .Where(File.Exists)
            .ToArray();

        if (archivos.Length != 2)
        {
          result = false;
          return result;
        }

        //var archivos = Directory.GetFiles(Util.GetBaseRomPath(), "*.zip");
        List<bool> resultados = new List<bool>();
        foreach (var archivo in archivos)
        {
          string hash = CalcularSHA256(archivo);
          if(hash == kof2002_verde_hash || hash == kf2k2pls_verde_hash)
          {
            resultados.Add(true);
          }
          else
          {
            resultados.Add(false);
          }
        }
        result = resultados.All(x => x == true);
        return result;
      }
      result = false;
      return result;
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
    private void CargarTemaKofOriginal()
    {
      // Fondo principal
      this.BackColor = AppColorsKofOriginal.DarkPrimary;

      // Barra superior o panel
      //panelHeader.BackColor = AppColors.Primary;

      // Botones
      SetColorButton(btnActivateOriginalKof2002, AppColorsKofOriginal.Accent, AppColorsKofOriginal.TextIcons);
      SetColorButton(btnActivateKof2002Green, AppColorsKofOriginal.Accent, AppColorsKofOriginal.TextIcons);

      //btnExit.BackColor = AppColors.DarkPrimary;
      //btnExit.ForeColor = AppColors.TextIcons;

      //// Labels
      label1.ForeColor = AppColorsKofOriginal.TextIcons;
      //lblSubtitle.ForeColor = AppColors.SecondaryText;

      //// Separadores
      //panelDivider.BackColor = AppColors.Divider;
    }
    private void CargarTemaKofVerde()
    {
      // Fondo principal
      this.BackColor = AppColorsKofVerde.DarkPrimary;

      // Barra superior o panel
      //panelHeader.BackColor = AppColors.Primary;

      // Botones
      SetColorButton(btnActivateOriginalKof2002, AppColorsKofVerde.Accent, AppColorsKofVerde.TextIcons);
      SetColorButton(btnActivateKof2002Green, AppColorsKofVerde.Accent, AppColorsKofVerde.TextIcons);

      //btnExit.BackColor = AppColors.DarkPrimary;
      //btnExit.ForeColor = AppColors.TextIcons;

      //// Labels
      label1.ForeColor = AppColorsKofVerde.TextIcons;
      //lblSubtitle.ForeColor = AppColors.SecondaryText;

      //// Separadores
      //panelDivider.BackColor = AppColors.Divider;
    }
    private void SetColorButton(Button btn, Color backgroundColor, Color textIconsColor)
    {
      btn.BackColor = backgroundColor;
      btn.ForeColor = textIconsColor;
      //btn.ForeColor = AppColors.Primary;
      btn.FlatStyle = FlatStyle.Flat;
      btn.FlatAppearance.BorderSize = 0;
    }

    private void txtRutaBaseRoms_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtRutaBaseRoms_DoubleClick(object sender, EventArgs e)
    {
      string path = Util.GetBaseRomPath();

      if (string.IsNullOrWhiteSpace(path))
      {
        MessageBox.Show("No hay carpeta base ROMs definida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (Directory.Exists(path))
      {
        // Abre carpeta en el explorador
        Process.Start("explorer.exe", path);
      }
      else
      {
        MessageBox.Show("La carpeta ROMs no existe: " + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
