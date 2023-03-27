using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
  public partial class mainForm : Form
  {
    static public void PrintAppearance(ref int appearanceNumber, PictureBox appearancePicture)
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
          PrintAppearance(ref appearanceNumber, appearancePicture);
          break;
      }
    }

    static public void PrintPet(ref int petNumber, PictureBox petPicture)
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
          PrintPet(ref petNumber, petPicture);
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

    private void appearanceBox_Click(object sender, EventArgs e)
    {
      
    }

    private void weaponPicture_Click(object sender, EventArgs e)
    {

    }

    private void nextAppearance_Click(object sender, EventArgs e)
    {
      PrintAppearance(ref appearanceNumber, appearancePicture);
    }

    private void nextPet_Click(object sender, EventArgs e)
    {
      PrintPet(ref petNumber, petPicture);
    }
  }
}
