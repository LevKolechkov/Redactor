using System;

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

    public object GetMemento()
    {
      return new Memento
      {
        NumberOfAppearance = AppearanceNumber,
        NumberOfPet = PetNumber,
        NumberOfWeapon = WeaponNumber
      };
    }

    public void SetMemento(object memento)
    {
      if (memento is Memento)
      {
        var mem = memento as Memento;
        mem.NumberOfAppearance = AppearanceNumber;
        mem.NumberOfPet = PetNumber;
        mem.NumberOfWeapon = WeaponNumber;
      }
    }
  }
}
