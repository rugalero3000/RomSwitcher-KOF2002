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
      ActivarRom(Util.GetBaseRomPath(), "kof2002_original", "kof2002.zip");
      ActivarRom(Util.GetBaseRomPath(), "kf2k2pls_original", "kf2k2pls.zip");
      //Refrescar();
      MessageBox.Show("Activadas ROMs originales.");
    }

    private void btnActivateKof2002Green_Click(object sender, EventArgs e)
    {
      ActivarRom(Util.GetBaseRomPath(), "kof2002_verde", "kof2002.zip");
      ActivarRom(Util.GetBaseRomPath(), "kf2k2pls_verde", "kf2k2pls.zip");
      //Refrescar();
      MessageBox.Show("Activadas ROMs hack (verde).");
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
        MessageBox.Show($"Error al activar la ROM: {ex.Message}");
      }

    }
  }
}
