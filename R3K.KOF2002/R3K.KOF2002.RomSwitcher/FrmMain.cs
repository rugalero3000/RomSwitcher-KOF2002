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
      txtRutaBaseRoms.Text = Util.GetBaseRomPath();
    }
  }
}
