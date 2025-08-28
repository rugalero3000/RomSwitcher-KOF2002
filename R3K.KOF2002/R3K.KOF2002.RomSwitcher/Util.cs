using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3K.KOF2002.RomSwitcher
{
  internal static class Util
  {
    public static string GetBaseRomPath()
    {
      if (string.IsNullOrEmpty(Properties.Settings.Default.RutaBaseRoms))
      {
        return Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Fightcade", "emulator", "fbneo", "ROMs");
      }

      return Properties.Settings.Default.RutaBaseRoms;
    }
    public static void SaveBaseRomPath(string path)
    {
      Properties.Settings.Default.RutaBaseRoms = path;
      Properties.Settings.Default.Save();
    }
  }
}
