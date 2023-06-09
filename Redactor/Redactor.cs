﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//Origibator
namespace Redactor
{
  public partial class mainForm : Form
  {
    int appearanceNumber;
    int petNumber;
    int weaponNumber;

    Characteristic characteristic = null;

    public mainForm()
    {
      characteristic = new Characteristic();

      appearanceNumber = characteristic.AppearanceNumber;
      petNumber = characteristic.PetNumber;
      weaponNumber = characteristic.WeaponNumber;

      InitializeComponent();
    } 

    static public void PrintNextAppearance(ref int appearanceNumber, PictureBox appearancePicture)
    {
      ++appearanceNumber;
      switch (appearanceNumber)
      {
        case 1:
          appearancePicture.Image = Properties.Resources.MrBeast;
          break;
        case 2:
          appearancePicture.Image = Properties.Resources.Scott;
          break;
        case 3:
          appearancePicture.Image = Properties.Resources.YandereDev;
          break;
        default:
          appearanceNumber = 0;
          PrintNextAppearance(ref appearanceNumber, appearancePicture);
          break;
      }
    }

    static public void PrintPreviousAppearance(ref int appearanceNumber, PictureBox appearancePicture)
    {
      --appearanceNumber;
      switch (appearanceNumber)
      {
        case 1:
          appearancePicture.Image = Properties.Resources.MrBeast;
          break;
        case 2:
          appearancePicture.Image = Properties.Resources.Scott;
          break;
        case 3:
          appearancePicture.Image = Properties.Resources.YandereDev;
          break;
        default:
          appearanceNumber = 4;
          PrintPreviousAppearance(ref appearanceNumber, appearancePicture);
          break;
      }
    }

    static public void PrintNextPet(ref int petNumber, PictureBox petPicture)
    {
      ++petNumber;
      switch (petNumber)
      {
        case 1:
          petPicture.Image = Properties.Resources.Cheems;
          break;
        case 2:
          petPicture.Image = Properties.Resources.Feddy;
          break;
        case 3:
          petPicture.Image = Properties.Resources.Unicorn;
          break;
        default:
          petNumber = 0;
          PrintNextPet(ref petNumber, petPicture);
          break;
      }
    }
    
    static public void PrintPreviousPet(ref int petNumber, PictureBox petPicture)
    {
      --petNumber;
      switch (petNumber)
      {
        case 1:
          petPicture.Image = Properties.Resources.Cheems;
          break;
        case 2:
          petPicture.Image = Properties.Resources.Feddy;
          break;
        case 3:
          petPicture.Image= Properties.Resources.Unicorn;
          break;
        default:
          petNumber = 4;
          PrintPreviousPet(ref petNumber, petPicture);
          break;
      }
    }

    static public void PrintNextWeapon(ref int weaponNumber, PictureBox weaponPicture)
    {
      ++weaponNumber;
      switch (weaponNumber)
      {
        case 1:
          weaponPicture.Image = Properties.Resources.Screwdriver;
          break;
        case 2:
          weaponPicture.Image = Properties.Resources.Rag;
          break;
        case 3:
          weaponPicture.Image = Properties.Resources.Money;
          break;
        default:
          weaponNumber = 0;
          PrintNextWeapon(ref weaponNumber, weaponPicture);
          break;
      }
    }

    static public void PrintPreviousWeapon(ref int weaponNumber, PictureBox weaponPicture)
    {
      --weaponNumber;
      switch (weaponNumber)
      {
        case 1:
          weaponPicture.Image = Properties.Resources.Screwdriver;
          break;
        case 2:
          weaponPicture.Image = Properties.Resources.Rag;
          break;
        case 3:
          weaponPicture.Image = Properties.Resources.Money;
          break;
        default: 
          weaponNumber = 4;
          PrintPreviousWeapon(ref weaponNumber, weaponPicture);
          break;
      }
    }

    private void nextAppearance_Click(object sender, EventArgs e)
    {
      PrintNextAppearance(ref appearanceNumber, appearancePicture);
    }

    private void nextPet_Click(object sender, EventArgs e)
    {
      PrintNextPet(ref petNumber, petPicture);
    }

    private void nextWeapon_Click(object sender, EventArgs e)
    {
      PrintNextWeapon(ref weaponNumber, weaponPicture);
    }

    private void previousAppearance_Click(object sender, EventArgs e)
    {
        PrintPreviousAppearance(ref appearanceNumber, appearancePicture);
    }

    private void previousPet_Click(object sender, EventArgs e)
    {
        PrintPreviousPet(ref petNumber, petPicture);
    }

    private void previousWeapon_Click(object sender, EventArgs e)
    {
        PrintPreviousWeapon(ref weaponNumber, weaponPicture);
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    string filePath = Path.Combine(Application.StartupPath, "Save.txt");

    private void saveButton_Click(object sender, EventArgs e)
    {
      stateBox.Visible = true;
      stateBox.Text = "Сохранение...";

      characteristic.AppearanceNumber = appearanceNumber;
      characteristic.PetNumber = petNumber;
      characteristic.WeaponNumber = weaponNumber;

      Caretaker ct = new Caretaker();
      ct.SaveState(characteristic);

      stateBox.Text = "Сохранение выполнено";
    }

    private void restoreButton_Click(object sender, EventArgs e)
    {
      stateBox.Visible = true;
      stateBox.Text = "Восстанавливаю...";

      characteristic.AppearanceNumber = appearanceNumber;
      characteristic.PetNumber = petNumber;
      characteristic.WeaponNumber = weaponNumber;

      Caretaker ct = new Caretaker();
      ct.RestoreState(characteristic);
      

      appearanceNumber = characteristic.AppearanceNumber;
      petNumber = characteristic.PetNumber;
      weaponNumber = characteristic.WeaponNumber;

      switch (appearanceNumber)
      {
        case 0:
          appearancePicture.Image = Properties.Resources.Empty;
          break;
        case 1:
          appearancePicture.Image = Properties.Resources.MrBeast;
          break;
        case 2:
          appearancePicture.Image = Properties.Resources.Scott;
          break;
        case 3:
          appearancePicture.Image = Properties.Resources.YandereDev;
          break;
      }

      switch (petNumber)
      {
        case 0:
          petPicture.Image = Properties.Resources.Empty;
          break;
        case 1:
          petPicture.Image = Properties.Resources.Cheems;
          break;
        case 2:
          petPicture.Image = Properties.Resources.Feddy;
          break;
        case 3:
          petPicture.Image = Properties.Resources.Unicorn;
          break;
      }

      switch (weaponNumber)
      {
        case 0:
          weaponPicture.Image = Properties.Resources.Empty;
          break;
        case 1:
          weaponPicture.Image = Properties.Resources.Screwdriver;
          break;
        case 2:
          weaponPicture.Image = Properties.Resources.Rag;
          break;
        case 3:
          weaponPicture.Image = Properties.Resources.Money;
          break;
      }

      stateBox.Text = "Восстановление выполнено";
    }

    Point lastPoint;

    private void characterLabel_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left) 
      {
        this.Left += e.X - lastPoint.X;
        this.Top += e.Y - lastPoint.Y;
      }
    }

    private void characterLabel_MouseDown(object sender, MouseEventArgs e)
    {
        lastPoint = new Point(e.X, e.Y);
    }
  }
}
