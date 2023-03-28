using System;

namespace Redactor
{
  class Memento
  {
    public string nameOfAppearance { get; private set; }
    public string nameOfPet { get; private set; }
    public string nameOfWeapon { get; private set; }
    public Memento (string State)
    {
      this.nameOfAppearance = nameOfAppearance;
      this.nameOfPet = nameOfPet;
      this.nameOfWeapon = nameOfWeapon;

    }
  }
}
