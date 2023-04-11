using System;
using System.IO;
using System.Windows.Forms;

namespace Redactor
{
  //Originator
  class Characteristic : IOriginator
  {
    public int AppearanceNumber { get; set; }
    public int PetNumber { get; set; }
    public int WeaponNumber { get; set; }

    public Characteristic() 
    {
      AppearanceNumber = 0;
      PetNumber = 0;
      WeaponNumber = 0;
    }

    public Memento GetMemento()
    {
      return new Memento
      {
        filePathToSaveFile = Path.Combine(Application.StartupPath, "Save.txt"),
        AppearanceNumber = this.AppearanceNumber,
        PetNumber = this.PetNumber,
        WeaponNumber = this.WeaponNumber
      };
    }

    public void SetMemento(object memento)
    {
      
    }
  }
}
