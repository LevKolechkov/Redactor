namespace Redactor
{
  partial class mainForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
      this.Title = new System.Windows.Forms.TextBox();
      this.appearanceBox = new System.Windows.Forms.TextBox();
      this.petBox = new System.Windows.Forms.TextBox();
      this.weaponBox = new System.Windows.Forms.TextBox();
      this.appearancePicture = new System.Windows.Forms.PictureBox();
      this.petPicture = new System.Windows.Forms.PictureBox();
      this.weaponPicture = new System.Windows.Forms.PictureBox();
      this.nextAppearance = new System.Windows.Forms.Button();
      this.previousAppearance = new System.Windows.Forms.Button();
      this.previousPet = new System.Windows.Forms.Button();
      this.nextPet = new System.Windows.Forms.Button();
      this.previousWeapon = new System.Windows.Forms.Button();
      this.nextWeapon = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.appearancePicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.petPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.weaponPicture)).BeginInit();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(197, 25);
      this.Title.Margin = new System.Windows.Forms.Padding(4);
      this.Title.Name = "Title";
      this.Title.ReadOnly = true;
      this.Title.Size = new System.Drawing.Size(683, 64);
      this.Title.TabIndex = 0;
      this.Title.Text = "Create your character";
      this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // appearanceBox
      // 
      this.appearanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.appearanceBox.Location = new System.Drawing.Point(59, 143);
      this.appearanceBox.Margin = new System.Windows.Forms.Padding(4);
      this.appearanceBox.Name = "appearanceBox";
      this.appearanceBox.ReadOnly = true;
      this.appearanceBox.Size = new System.Drawing.Size(225, 34);
      this.appearanceBox.TabIndex = 1;
      this.appearanceBox.Text = "Appearance";
      this.appearanceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // petBox
      // 
      this.petBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.petBox.Location = new System.Drawing.Point(421, 143);
      this.petBox.Margin = new System.Windows.Forms.Padding(4);
      this.petBox.Name = "petBox";
      this.petBox.ReadOnly = true;
      this.petBox.Size = new System.Drawing.Size(225, 34);
      this.petBox.TabIndex = 2;
      this.petBox.Text = "Pet";
      this.petBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.petBox.TextChanged += new System.EventHandler(this.petBox_TextChanged);
      // 
      // weaponBox
      // 
      this.weaponBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.weaponBox.Location = new System.Drawing.Point(776, 143);
      this.weaponBox.Margin = new System.Windows.Forms.Padding(4);
      this.weaponBox.Name = "weaponBox";
      this.weaponBox.ReadOnly = true;
      this.weaponBox.Size = new System.Drawing.Size(225, 34);
      this.weaponBox.TabIndex = 3;
      this.weaponBox.Text = "Weapon";
      this.weaponBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // appearancePicture
      // 
      this.appearancePicture.Image = ((System.Drawing.Image)(resources.GetObject("appearancePicture.Image")));
      this.appearancePicture.Location = new System.Drawing.Point(59, 226);
      this.appearancePicture.Margin = new System.Windows.Forms.Padding(4);
      this.appearancePicture.Name = "appearancePicture";
      this.appearancePicture.Size = new System.Drawing.Size(227, 146);
      this.appearancePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.appearancePicture.TabIndex = 4;
      this.appearancePicture.TabStop = false;
      this.appearancePicture.Click += new System.EventHandler(this.appearanceBox_Click);
      // 
      // petPicture
      // 
      this.petPicture.Image = ((System.Drawing.Image)(resources.GetObject("petPicture.Image")));
      this.petPicture.Location = new System.Drawing.Point(421, 226);
      this.petPicture.Margin = new System.Windows.Forms.Padding(4);
      this.petPicture.Name = "petPicture";
      this.petPicture.Size = new System.Drawing.Size(227, 146);
      this.petPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.petPicture.TabIndex = 5;
      this.petPicture.TabStop = false;
      // 
      // weaponPicture
      // 
      this.weaponPicture.Image = ((System.Drawing.Image)(resources.GetObject("weaponPicture.Image")));
      this.weaponPicture.Location = new System.Drawing.Point(776, 226);
      this.weaponPicture.Margin = new System.Windows.Forms.Padding(4);
      this.weaponPicture.Name = "weaponPicture";
      this.weaponPicture.Size = new System.Drawing.Size(227, 146);
      this.weaponPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.weaponPicture.TabIndex = 6;
      this.weaponPicture.TabStop = false;
      this.weaponPicture.Click += new System.EventHandler(this.weaponPicture_Click);
      // 
      // nextAppearance
      // 
      this.nextAppearance.Location = new System.Drawing.Point(172, 395);
      this.nextAppearance.Margin = new System.Windows.Forms.Padding(4);
      this.nextAppearance.Name = "nextAppearance";
      this.nextAppearance.Size = new System.Drawing.Size(113, 66);
      this.nextAppearance.TabIndex = 7;
      this.nextAppearance.Text = "Next";
      this.nextAppearance.UseVisualStyleBackColor = true;
      this.nextAppearance.Click += new System.EventHandler(this.nextAppearance_Click);
      // 
      // previousAppearance
      // 
      this.previousAppearance.Location = new System.Drawing.Point(59, 395);
      this.previousAppearance.Margin = new System.Windows.Forms.Padding(4);
      this.previousAppearance.Name = "previousAppearance";
      this.previousAppearance.Size = new System.Drawing.Size(113, 66);
      this.previousAppearance.TabIndex = 8;
      this.previousAppearance.Text = "Previous";
      this.previousAppearance.UseVisualStyleBackColor = true;
      // 
      // previousPet
      // 
      this.previousPet.Location = new System.Drawing.Point(421, 395);
      this.previousPet.Margin = new System.Windows.Forms.Padding(4);
      this.previousPet.Name = "previousPet";
      this.previousPet.Size = new System.Drawing.Size(113, 66);
      this.previousPet.TabIndex = 9;
      this.previousPet.Text = "Previous";
      this.previousPet.UseVisualStyleBackColor = true;
      // 
      // nextPet
      // 
      this.nextPet.Location = new System.Drawing.Point(535, 395);
      this.nextPet.Margin = new System.Windows.Forms.Padding(4);
      this.nextPet.Name = "nextPet";
      this.nextPet.Size = new System.Drawing.Size(113, 66);
      this.nextPet.TabIndex = 10;
      this.nextPet.Text = "Next";
      this.nextPet.UseVisualStyleBackColor = true;
      this.nextPet.Click += new System.EventHandler(this.nextPet_Click);
      // 
      // previousWeapon
      // 
      this.previousWeapon.Location = new System.Drawing.Point(776, 395);
      this.previousWeapon.Margin = new System.Windows.Forms.Padding(4);
      this.previousWeapon.Name = "previousWeapon";
      this.previousWeapon.Size = new System.Drawing.Size(113, 66);
      this.previousWeapon.TabIndex = 11;
      this.previousWeapon.Text = "Previous";
      this.previousWeapon.UseVisualStyleBackColor = true;
      // 
      // nextWeapon
      // 
      this.nextWeapon.Location = new System.Drawing.Point(889, 395);
      this.nextWeapon.Margin = new System.Windows.Forms.Padding(4);
      this.nextWeapon.Name = "nextWeapon";
      this.nextWeapon.Size = new System.Drawing.Size(113, 66);
      this.nextWeapon.TabIndex = 12;
      this.nextWeapon.Text = "Next";
      this.nextWeapon.UseVisualStyleBackColor = true;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(964, 497);
      this.saveButton.Margin = new System.Windows.Forms.Padding(4);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(87, 42);
      this.saveButton.TabIndex = 13;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.nextWeapon);
      this.Controls.Add(this.previousWeapon);
      this.Controls.Add(this.nextPet);
      this.Controls.Add(this.previousPet);
      this.Controls.Add(this.previousAppearance);
      this.Controls.Add(this.nextAppearance);
      this.Controls.Add(this.weaponPicture);
      this.Controls.Add(this.petPicture);
      this.Controls.Add(this.appearancePicture);
      this.Controls.Add(this.weaponBox);
      this.Controls.Add(this.petBox);
      this.Controls.Add(this.appearanceBox);
      this.Controls.Add(this.Title);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "mainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.mainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.appearancePicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.petPicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.weaponPicture)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox Title;
    private System.Windows.Forms.TextBox appearanceBox;
    private System.Windows.Forms.TextBox petBox;
    private System.Windows.Forms.TextBox weaponBox;
    private System.Windows.Forms.PictureBox appearancePicture;
    private System.Windows.Forms.PictureBox petPicture;
    private System.Windows.Forms.PictureBox weaponPicture;
    private System.Windows.Forms.Button nextAppearance;
    private System.Windows.Forms.Button previousAppearance;
    private System.Windows.Forms.Button previousPet;
    private System.Windows.Forms.Button nextPet;
    private System.Windows.Forms.Button previousWeapon;
    private System.Windows.Forms.Button nextWeapon;
    private System.Windows.Forms.Button saveButton;
  }
}

