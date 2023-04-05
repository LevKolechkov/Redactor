using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
  internal static class Program
  {
    [STAThread]

    public static void GetSaveFile(FileStream saveFile)
    {
      string filePath = Path.Combine(Application.StartupPath, "Save.txt");

      saveFile = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

    }

    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      mainForm mainForm = new mainForm();
      Application.Run(mainForm);
    }
  }
}
