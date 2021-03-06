﻿namespace Project.Engine.Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLabel.Location = new System.Drawing.Point(8, 41);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(47, 16);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class";
            // 
            // Mage
            // 
            this.Mage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mage.Location = new System.Drawing.Point(8, 73);
            this.Mage.Name = "Mage";
            this.Mage.Size = new System.Drawing.Size(75, 40);
            this.Mage.TabIndex = 1;
            this.Mage.Text = "Mage";
            this.Mage.UseVisualStyleBackColor = true;
            this.Mage.Click += new System.EventHandler(this.Mage_Click);
            // 
            // Warrior
            // 
            this.Warrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Warrior.Location = new System.Drawing.Point(90, 73);
            this.Warrior.Name = "Warrior";
            this.Warrior.Size = new System.Drawing.Size(75, 40);
            this.Warrior.TabIndex = 2;
            this.Warrior.Text = "Warrior";
            this.Warrior.UseVisualStyleBackColor = true;
            this.Warrior.Click += new System.EventHandler(this.Warrior_Click);
            // 
            // Paladin
            // 
            this.Paladin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paladin.Location = new System.Drawing.Point(90, 125);
            this.Paladin.Name = "Paladin";
            this.Paladin.Size = new System.Drawing.Size(75, 40);
            this.Paladin.TabIndex = 3;
            this.Paladin.Text = "Paladin";
            this.Paladin.UseVisualStyleBackColor = true;
            this.Paladin.Click += new System.EventHandler(this.Paladin_Click);
            // 
            // Druid
            // 
            this.Druid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Druid.Location = new System.Drawing.Point(8, 125);
            this.Druid.Name = "Druid";
            this.Druid.Size = new System.Drawing.Size(75, 40);
            this.Druid.TabIndex = 4;
            this.Druid.Text = "Druid";
            this.Druid.UseVisualStyleBackColor = true;
            this.Druid.Click += new System.EventHandler(this.Druid_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(8, 203);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(59, 16);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // Male
            // 
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Male.Location = new System.Drawing.Point(8, 239);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(75, 32);
            this.Male.TabIndex = 6;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.Click += new System.EventHandler(this.Male_Click);
            // 
            // Female
            // 
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Female.Location = new System.Drawing.Point(89, 239);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 33);
            this.Female.TabIndex = 7;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.Click += new System.EventHandler(this.Female_Click);
            // 
            // Unknown
            // 
            this.Unknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unknown.Location = new System.Drawing.Point(8, 277);
            this.Unknown.Name = "Unknown";
            this.Unknown.Size = new System.Drawing.Size(157, 32);
            this.Unknown.TabIndex = 8;
            this.Unknown.Text = "Unknown";
            this.Unknown.UseVisualStyleBackColor = true;
            this.Unknown.Click += new System.EventHandler(this.Unknown_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(8, 546);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(157, 56);
            this.Create.TabIndex = 9;
            this.Create.Text = "CREATE";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(8, 501);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(8, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "1v1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(89, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "2v2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Game Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // CharacterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
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
            this.Text = "Create Character";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}