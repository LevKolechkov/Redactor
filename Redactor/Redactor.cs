﻿using System;
using System.Windows.Forms;

namespace Redactor
{
  public partial class mainForm : Form
  {
    static public void PrintNextAppearance(ref int appearanceNumber, PictureBox appearancePicture)
    {
      switch (++appearanceNumber)
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
      switch (--appearanceNumber)
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
      switch (++petNumber)
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
      switch (--petNumber)
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
      switch (++weaponNumber)
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
      switch (--weaponNumber)
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


    int appearanceNumber = 0;
    int petNumber = 0;
    int weaponNumber = 0;

    public mainForm()
    {
      InitializeComponent();
    }

    private void mainForm_Load(object sender, EventArgs e)
    {

    }

    private void petBox_TextChanged(object sender, EventArgs e)
    {

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
  }
}