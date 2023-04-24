using System;
using System.IO;
using System.Collections.Generic;

namespace Redactor
{
  class Caretaker
  {
    private Memento memento;

    public void SaveState(IOriginator originator)
    {
      memento = originator.GetMemento();

      string filePath = memento.FilePathToSaveFile;

      File.WriteAllText(filePath, $"{memento.AppearanceNumber}\n{memento.PetNumber}\n{memento.WeaponNumber}");

    }

    public void RestoreState(IOriginator originator)
    {
      Memento memento = new Memento();

      originator.SetMemento(memento);
    }
  }
}
