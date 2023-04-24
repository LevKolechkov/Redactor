using System;
using System.IO;
using System.Windows.Forms;

namespace Redactor
{
  class Memento
  {
    public int AppearanceNumber { get; set; }
    public int PetNumber { get; set; }
    public int WeaponNumber { get; set; }

    public string FilePathToSaveFile { get; set; }

    public Memento()
    {
    }
  }
}
