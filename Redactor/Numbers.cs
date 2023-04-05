using System;

namespace Redactor
{
  //Originator
  public class Numbers : IOriginator
  {
    public int AppearanceNumber { get; set; }
    public int PetNumber { get; set; }
    public int WeaponNumber { get; set; }

    public Numbers(int appearanceNumber, int petNumber, int weaponNumber) 
    {
      AppearanceNumber = appearanceNumber;
      PetNumber = petNumber;
      WeaponNumber = weaponNumber;
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
