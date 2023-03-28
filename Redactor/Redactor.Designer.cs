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
      this.Close = new System.Windows.Forms.Label();
      this.characterLabel = new System.Windows.Forms.Label();
      this.CloseButton = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.appearancePicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.petPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.weaponPicture)).BeginInit();
      this.SuspendLayout();
      // 
      // appearancePicture
      // 
      this.appearancePicture.Image = global::Redactor.Properties.Resources.Empty;
      this.appearancePicture.Location = new System.Drawing.Point(44, 159);
      this.appearancePicture.Name = "appearancePicture";
      this.appearancePicture.Size = new System.Drawing.Size(170, 119);
      this.appearancePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.appearancePicture.TabIndex = 4;
      this.appearancePicture.TabStop = false;
      // 
      // petPicture
      // 
      this.petPicture.Image = global::Redactor.Properties.Resources.Empty;
      this.petPicture.Location = new System.Drawing.Point(316, 159);
      this.petPicture.Name = "petPicture";
      this.petPicture.Size = new System.Drawing.Size(170, 119);
      this.petPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.petPicture.TabIndex = 5;
      this.petPicture.TabStop = false;
      // 
      // weaponPicture
      // 
      this.weaponPicture.Image = global::Redactor.Properties.Resources.Empty;
      this.weaponPicture.Location = new System.Drawing.Point(582, 159);
      this.weaponPicture.Name = "weaponPicture";
      this.weaponPicture.Size = new System.Drawing.Size(170, 119);
      this.weaponPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.weaponPicture.TabIndex = 6;
      this.weaponPicture.TabStop = false;
      // 
      // nextAppearance
      // 
      this.nextAppearance.Location = new System.Drawing.Point(129, 321);
      this.nextAppearance.Name = "nextAppearance";
      this.nextAppearance.Size = new System.Drawing.Size(85, 54);
      this.nextAppearance.TabIndex = 7;
      this.nextAppearance.Text = "Next";
      this.nextAppearance.UseVisualStyleBackColor = true;
      this.nextAppearance.Click += new System.EventHandler(this.nextAppearance_Click);
      // 
      // previousAppearance
      // 
      this.previousAppearance.Location = new System.Drawing.Point(44, 321);
      this.previousAppearance.Name = "previousAppearance";
      this.previousAppearance.Size = new System.Drawing.Size(85, 54);
      this.previousAppearance.TabIndex = 8;
      this.previousAppearance.Text = "Previous";
      this.previousAppearance.UseVisualStyleBackColor = true;
      this.previousAppearance.Click += new System.EventHandler(this.previousAppearance_Click);
      // 
      // previousPet
      // 
      this.previousPet.Location = new System.Drawing.Point(316, 321);
      this.previousPet.Name = "previousPet";
      this.previousPet.Size = new System.Drawing.Size(85, 54);
      this.previousPet.TabIndex = 9;
      this.previousPet.Text = "Previous";
      this.previousPet.UseVisualStyleBackColor = true;
      this.previousPet.Click += new System.EventHandler(this.previousPet_Click);
      // 
      // nextPet
      // 
      this.nextPet.Location = new System.Drawing.Point(401, 321);
      this.nextPet.Name = "nextPet";
      this.nextPet.Size = new System.Drawing.Size(85, 54);
      this.nextPet.TabIndex = 10;
      this.nextPet.Text = "Next";
      this.nextPet.UseVisualStyleBackColor = true;
      this.nextPet.Click += new System.EventHandler(this.nextPet_Click);
      // 
      // previousWeapon
      // 
      this.previousWeapon.Location = new System.Drawing.Point(582, 321);
      this.previousWeapon.Name = "previousWeapon";
      this.previousWeapon.Size = new System.Drawing.Size(85, 54);
      this.previousWeapon.TabIndex = 11;
      this.previousWeapon.Text = "Previous";
      this.previousWeapon.UseVisualStyleBackColor = true;
      this.previousWeapon.Click += new System.EventHandler(this.previousWeapon_Click);
      // 
      // nextWeapon
      // 
      this.nextWeapon.Location = new System.Drawing.Point(667, 321);
      this.nextWeapon.Name = "nextWeapon";
      this.nextWeapon.Size = new System.Drawing.Size(85, 54);
      this.nextWeapon.TabIndex = 12;
      this.nextWeapon.Text = "Next";
      this.nextWeapon.UseVisualStyleBackColor = true;
      this.nextWeapon.Click += new System.EventHandler(this.nextWeapon_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(723, 404);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(65, 34);
      this.saveButton.TabIndex = 13;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      // 
      // Close
      // 
      this.Close.AutoSize = true;
      this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Close.Location = new System.Drawing.Point(762, 9);
      this.Close.Name = "Close";
      this.Close.Size = new System.Drawing.Size(26, 25);
      this.Close.TabIndex = 15;
      this.Close.Text = "X";
      // 
      // characterLabel
      // 
      this.characterLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.characterLabel.Font = new System.Drawing.Font("Albertus Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.characterLabel.Location = new System.Drawing.Point(0, 0);
      this.characterLabel.Name = "characterLabel";
      this.characterLabel.Size = new System.Drawing.Size(800, 145);
      this.characterLabel.TabIndex = 16;
      this.characterLabel.Text = "Create your character";
      this.characterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // CloseButton
      // 
      this.CloseButton.AutoSize = true;
      this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseButton.Location = new System.Drawing.Point(756, 9);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(32, 31);
      this.CloseButton.TabIndex = 17;
      this.CloseButton.Text = "X";
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.CloseButton);
      this.Controls.Add(this.characterLabel);
      this.Controls.Add(this.Close);
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    private System.Windows.Forms.Label Close;
    private System.Windows.Forms.Label characterLabel;
    private System.Windows.Forms.Label CloseButton;
  }
}

