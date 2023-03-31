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

    public static FileStream GetFilePath()
    {
      string filePath = Path.Combine(Application.StartupPath, "Save.txt");

      return new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    }

    static void Main()
    {

      GetFilePath();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      mainForm mainForm = new mainForm();
      Application.Run(mainForm);

      
    }
  }
}
