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
        FilePathToSaveFile = Path.Combine(Application.StartupPath, "Save.txt"),
        AppearanceNumber = this.AppearanceNumber,
        PetNumber = this.PetNumber,
        WeaponNumber = this.WeaponNumber
      };
    }

    public void SetMemento(Memento memento)
    {
      var mementoForSet = memento;
      mementoForSet.FilePathToSaveFile = Path.Combine(Application.StartupPath, "Save.txt");

      string[] lines = File.ReadAllLines(mementoForSet.FilePathToSaveFile);
      int[] numbers = new int[lines.Length];
      
      for (int index = 0; index < lines.Length; ++index) 
      {
        numbers[index] = Convert.ToInt32(lines[index]);
      }

      AppearanceNumber = numbers[0];
      PetNumber = numbers[1];
      WeaponNumber = numbers[2];
    }
  }
}
