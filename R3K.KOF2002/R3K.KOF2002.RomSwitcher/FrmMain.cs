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
  public partial class FrmMain : Form
  {
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
      CargarTemaKofOriginal();
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
  }
}
