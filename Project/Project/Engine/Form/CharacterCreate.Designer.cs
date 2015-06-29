namespace Project.Engine.Form
{
    partial class CharacterCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classLabel = new System.Windows.Forms.Label();
            this.Mage = new System.Windows.Forms.Button();
            this.Warrior = new System.Windows.Forms.Button();
            this.Paladin = new System.Windows.Forms.Button();
            this.Druid = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.Button();
            this.Female = new System.Windows.Forms.Button();
            this.Unknown = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(12, 9);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class";
            // 
            // Mage
            // 
            this.Mage.Location = new System.Drawing.Point(12, 41);
            this.Mage.Name = "Mage";
            this.Mage.Size = new System.Drawing.Size(75, 46);
            this.Mage.TabIndex = 1;
            this.Mage.Text = "Mage";
            this.Mage.UseVisualStyleBackColor = true;
            this.Mage.Click += new System.EventHandler(this.Mage_Click);
            // 
            // Warrior
            // 
            this.Warrior.Location = new System.Drawing.Point(94, 41);
            this.Warrior.Name = "Warrior";
            this.Warrior.Size = new System.Drawing.Size(75, 46);
            this.Warrior.TabIndex = 2;
            this.Warrior.Text = "Warrior";
            this.Warrior.UseVisualStyleBackColor = true;
            this.Warrior.Click += new System.EventHandler(this.Warrior_Click);
            // 
            // Paladin
            // 
            this.Paladin.Location = new System.Drawing.Point(94, 93);
            this.Paladin.Name = "Paladin";
            this.Paladin.Size = new System.Drawing.Size(75, 46);
            this.Paladin.TabIndex = 3;
            this.Paladin.Text = "Paladin";
            this.Paladin.UseVisualStyleBackColor = true;
            this.Paladin.Click += new System.EventHandler(this.Paladin_Click);
            // 
            // Druid
            // 
            this.Druid.Location = new System.Drawing.Point(12, 93);
            this.Druid.Name = "Druid";
            this.Druid.Size = new System.Drawing.Size(75, 46);
            this.Druid.TabIndex = 4;
            this.Druid.Text = "Druid";
            this.Druid.UseVisualStyleBackColor = true;
            this.Druid.Click += new System.EventHandler(this.Druid_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 217);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // Male
            // 
            this.Male.Location = new System.Drawing.Point(12, 253);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(75, 45);
            this.Male.TabIndex = 6;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.Click += new System.EventHandler(this.Male_Click);
            // 
            // Female
            // 
            this.Female.Location = new System.Drawing.Point(93, 253);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 46);
            this.Female.TabIndex = 7;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.Click += new System.EventHandler(this.Female_Click);
            // 
            // Unknown
            // 
            this.Unknown.Location = new System.Drawing.Point(12, 304);
            this.Unknown.Name = "Unknown";
            this.Unknown.Size = new System.Drawing.Size(157, 45);
            this.Unknown.TabIndex = 8;
            this.Unknown.Text = "Unknown";
            this.Unknown.UseVisualStyleBackColor = true;
            this.Unknown.Click += new System.EventHandler(this.Unknown_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(15, 546);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(157, 56);
            this.Create.TabIndex = 9;
            this.Create.Text = "CREATE";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 489);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.video_games_rpg_guild_wars_guild_wars_nightfall_fantasy_art_guild_wars_eye_of_the_north_1280x960_www_wallpaperhi_com_16;
            this.pictureBox1.Location = new System.Drawing.Point(174, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "1V1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "2V2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "3V3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "4V4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CharacterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 614);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Unknown);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.Druid);
            this.Controls.Add(this.Paladin);
            this.Controls.Add(this.Warrior);
            this.Controls.Add(this.Mage);
            this.Controls.Add(this.classLabel);
            this.Name = "CharacterCreate";
            this.Text = "CharacterCreate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Button Mage;
        private System.Windows.Forms.Button Warrior;
        private System.Windows.Forms.Button Paladin;
        private System.Windows.Forms.Button Druid;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button Male;
        private System.Windows.Forms.Button Female;
        private System.Windows.Forms.Button Unknown;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}