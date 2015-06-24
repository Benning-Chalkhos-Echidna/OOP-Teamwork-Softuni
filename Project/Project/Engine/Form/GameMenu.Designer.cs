namespace Project.Engine.Form
{
    partial class GameMenu
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CharacterPanel = new System.Windows.Forms.TabPage();
            this.NameValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DefValue = new System.Windows.Forms.TextBox();
            this.AttValue = new System.Windows.Forms.TextBox();
            this.HpValue = new System.Windows.Forms.TextBox();
            this.IntValue = new System.Windows.Forms.TextBox();
            this.AgiValue = new System.Windows.Forms.TextBox();
            this.StrValue = new System.Windows.Forms.TextBox();
            this.DefenseLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.IntLabel = new System.Windows.Forms.Label();
            this.AgiLabel = new System.Windows.Forms.Label();
            this.StrLabel = new System.Windows.Forms.Label();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.CharacterClassValue = new System.Windows.Forms.TextBox();
            this.CharacterClass = new System.Windows.Forms.Label();
            this.CharacterPortrait = new System.Windows.Forms.PictureBox();
            this.StrPlayer = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RoundButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BattleConsole = new System.Windows.Forms.RichTextBox();
            this.TabControl.SuspendLayout();
            this.CharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPortrait)).BeginInit();
            this.StrPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CharacterPanel);
            this.TabControl.Controls.Add(this.StrPlayer);
            this.TabControl.Location = new System.Drawing.Point(13, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(928, 493);
            this.TabControl.TabIndex = 0;
            // 
            // CharacterPanel
            // 
            this.CharacterPanel.Controls.Add(this.NameValue);
            this.CharacterPanel.Controls.Add(this.label2);
            this.CharacterPanel.Controls.Add(this.GenderValue);
            this.CharacterPanel.Controls.Add(this.label1);
            this.CharacterPanel.Controls.Add(this.DefValue);
            this.CharacterPanel.Controls.Add(this.AttValue);
            this.CharacterPanel.Controls.Add(this.HpValue);
            this.CharacterPanel.Controls.Add(this.IntValue);
            this.CharacterPanel.Controls.Add(this.AgiValue);
            this.CharacterPanel.Controls.Add(this.StrValue);
            this.CharacterPanel.Controls.Add(this.DefenseLabel);
            this.CharacterPanel.Controls.Add(this.HealthLabel);
            this.CharacterPanel.Controls.Add(this.AttackLabel);
            this.CharacterPanel.Controls.Add(this.IntLabel);
            this.CharacterPanel.Controls.Add(this.AgiLabel);
            this.CharacterPanel.Controls.Add(this.StrLabel);
            this.CharacterPanel.Controls.Add(this.StatsLabel);
            this.CharacterPanel.Controls.Add(this.CharacterClassValue);
            this.CharacterPanel.Controls.Add(this.CharacterClass);
            this.CharacterPanel.Controls.Add(this.CharacterPortrait);
            this.CharacterPanel.Location = new System.Drawing.Point(4, 22);
            this.CharacterPanel.Name = "CharacterPanel";
            this.CharacterPanel.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterPanel.Size = new System.Drawing.Size(920, 467);
            this.CharacterPanel.TabIndex = 0;
            this.CharacterPanel.Text = "CharacterPanel";
            this.CharacterPanel.UseVisualStyleBackColor = true;
            // 
            // NameValue
            // 
            this.NameValue.Location = new System.Drawing.Point(452, 23);
            this.NameValue.Name = "NameValue";
            this.NameValue.ReadOnly = true;
            this.NameValue.Size = new System.Drawing.Size(133, 20);
            this.NameValue.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // GenderValue
            // 
            this.GenderValue.Location = new System.Drawing.Point(294, 286);
            this.GenderValue.Name = "GenderValue";
            this.GenderValue.ReadOnly = true;
            this.GenderValue.Size = new System.Drawing.Size(133, 20);
            this.GenderValue.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gender";
            // 
            // DefValue
            // 
            this.DefValue.Location = new System.Drawing.Point(344, 225);
            this.DefValue.Name = "DefValue";
            this.DefValue.ReadOnly = true;
            this.DefValue.Size = new System.Drawing.Size(133, 20);
            this.DefValue.TabIndex = 15;
            // 
            // AttValue
            // 
            this.AttValue.Location = new System.Drawing.Point(344, 199);
            this.AttValue.Name = "AttValue";
            this.AttValue.ReadOnly = true;
            this.AttValue.Size = new System.Drawing.Size(133, 20);
            this.AttValue.TabIndex = 14;
            // 
            // HpValue
            // 
            this.HpValue.Location = new System.Drawing.Point(344, 173);
            this.HpValue.Name = "HpValue";
            this.HpValue.ReadOnly = true;
            this.HpValue.Size = new System.Drawing.Size(133, 20);
            this.HpValue.TabIndex = 13;
            // 
            // IntValue
            // 
            this.IntValue.Location = new System.Drawing.Point(344, 140);
            this.IntValue.Name = "IntValue";
            this.IntValue.ReadOnly = true;
            this.IntValue.Size = new System.Drawing.Size(133, 20);
            this.IntValue.TabIndex = 12;
            // 
            // AgiValue
            // 
            this.AgiValue.Location = new System.Drawing.Point(344, 114);
            this.AgiValue.Name = "AgiValue";
            this.AgiValue.ReadOnly = true;
            this.AgiValue.Size = new System.Drawing.Size(133, 20);
            this.AgiValue.TabIndex = 11;
            // 
            // StrValue
            // 
            this.StrValue.Location = new System.Drawing.Point(344, 88);
            this.StrValue.Name = "StrValue";
            this.StrValue.ReadOnly = true;
            this.StrValue.Size = new System.Drawing.Size(133, 20);
            this.StrValue.TabIndex = 10;
            // 
            // DefenseLabel
            // 
            this.DefenseLabel.AutoSize = true;
            this.DefenseLabel.Location = new System.Drawing.Point(291, 228);
            this.DefenseLabel.Name = "DefenseLabel";
            this.DefenseLabel.Size = new System.Drawing.Size(50, 13);
            this.DefenseLabel.TabIndex = 9;
            this.DefenseLabel.Text = "Defense:";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(291, 176);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(44, 13);
            this.HealthLabel.TabIndex = 8;
            this.HealthLabel.Text = "Health: ";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(291, 202);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(41, 13);
            this.AttackLabel.TabIndex = 7;
            this.AttackLabel.Text = "Attack:";
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(291, 143);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(50, 13);
            this.IntLabel.TabIndex = 6;
            this.IntLabel.Text = "Intellect: ";
            // 
            // AgiLabel
            // 
            this.AgiLabel.AutoSize = true;
            this.AgiLabel.Location = new System.Drawing.Point(294, 117);
            this.AgiLabel.Name = "AgiLabel";
            this.AgiLabel.Size = new System.Drawing.Size(40, 13);
            this.AgiLabel.TabIndex = 5;
            this.AgiLabel.Text = "Agility: ";
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.Location = new System.Drawing.Point(291, 91);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(50, 13);
            this.StrLabel.TabIndex = 4;
            this.StrLabel.Text = "Strength:";
            // 
            // StatsLabel
            // 
            this.StatsLabel.AutoSize = true;
            this.StatsLabel.Location = new System.Drawing.Point(288, 56);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(31, 13);
            this.StatsLabel.TabIndex = 3;
            this.StatsLabel.Text = "Stats";
            // 
            // CharacterClassValue
            // 
            this.CharacterClassValue.Location = new System.Drawing.Point(287, 23);
            this.CharacterClassValue.Name = "CharacterClassValue";
            this.CharacterClassValue.ReadOnly = true;
            this.CharacterClassValue.Size = new System.Drawing.Size(133, 20);
            this.CharacterClassValue.TabIndex = 2;
            // 
            // CharacterClass
            // 
            this.CharacterClass.AutoSize = true;
            this.CharacterClass.Location = new System.Drawing.Point(288, 7);
            this.CharacterClass.Name = "CharacterClass";
            this.CharacterClass.Size = new System.Drawing.Size(32, 13);
            this.CharacterClass.TabIndex = 1;
            this.CharacterClass.Text = "Class";
            // 
            // CharacterPortrait
            // 
            this.CharacterPortrait.Image = global::Project.Properties.Resources.femaleMage;
            this.CharacterPortrait.Location = new System.Drawing.Point(3, 3);
            this.CharacterPortrait.Name = "CharacterPortrait";
            this.CharacterPortrait.Size = new System.Drawing.Size(278, 431);
            this.CharacterPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharacterPortrait.TabIndex = 0;
            this.CharacterPortrait.TabStop = false;
            // 
            // StrPlayer
            // 
            this.StrPlayer.Controls.Add(this.textBox5);
            this.StrPlayer.Controls.Add(this.RoundButton);
            this.StrPlayer.Controls.Add(this.label7);
            this.StrPlayer.Controls.Add(this.textBox6);
            this.StrPlayer.Controls.Add(this.label8);
            this.StrPlayer.Controls.Add(this.textBox7);
            this.StrPlayer.Controls.Add(this.label9);
            this.StrPlayer.Controls.Add(this.textBox8);
            this.StrPlayer.Controls.Add(this.label10);
            this.StrPlayer.Controls.Add(this.textBox3);
            this.StrPlayer.Controls.Add(this.label5);
            this.StrPlayer.Controls.Add(this.textBox4);
            this.StrPlayer.Controls.Add(this.label6);
            this.StrPlayer.Controls.Add(this.textBox2);
            this.StrPlayer.Controls.Add(this.label4);
            this.StrPlayer.Controls.Add(this.textBox1);
            this.StrPlayer.Controls.Add(this.label3);
            this.StrPlayer.Controls.Add(this.BattleConsole);
            this.StrPlayer.Location = new System.Drawing.Point(4, 22);
            this.StrPlayer.Name = "StrPlayer";
            this.StrPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.StrPlayer.Size = new System.Drawing.Size(920, 467);
            this.StrPlayer.TabIndex = 1;
            this.StrPlayer.Text = "BattleMenu";
            this.StrPlayer.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(625, 156);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(277, 46);
            this.textBox5.TabIndex = 18;
            // 
            // RoundButton
            // 
            this.RoundButton.Location = new System.Drawing.Point(423, 441);
            this.RoundButton.Name = "RoundButton";
            this.RoundButton.Size = new System.Drawing.Size(75, 23);
            this.RoundButton.TabIndex = 1;
            this.RoundButton.Text = "Fight";
            this.RoundButton.UseVisualStyleBackColor = true;
            this.RoundButton.Click += new System.EventHandler(this.RoundButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "LAbel 7";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(625, 48);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(277, 46);
            this.textBox6.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(625, 378);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(277, 46);
            this.textBox7.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(625, 265);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(277, 46);
            this.textBox8.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(622, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 378);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(277, 46);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 270);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(277, 46);
            this.textBox4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 161);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 46);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(277, 46);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // BattleConsole
            // 
            this.BattleConsole.Location = new System.Drawing.Point(306, 6);
            this.BattleConsole.Name = "BattleConsole";
            this.BattleConsole.Size = new System.Drawing.Size(304, 418);
            this.BattleConsole.TabIndex = 2;
            this.BattleConsole.Text = "";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 508);
            this.Controls.Add(this.TabControl);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.TabControl.ResumeLayout(false);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPortrait)).EndInit();
            this.StrPlayer.ResumeLayout(false);
            this.StrPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CharacterPanel;
        private System.Windows.Forms.TextBox CharacterClassValue;
        private System.Windows.Forms.Label CharacterClass;
        private System.Windows.Forms.PictureBox CharacterPortrait;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.Label AgiLabel;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.Label StatsLabel;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label DefenseLabel;
        private System.Windows.Forms.TextBox DefValue;
        private System.Windows.Forms.TextBox AttValue;
        private System.Windows.Forms.TextBox HpValue;
        private System.Windows.Forms.TextBox IntValue;
        private System.Windows.Forms.TextBox AgiValue;
        private System.Windows.Forms.TextBox StrValue;
        private System.Windows.Forms.TextBox GenderValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage StrPlayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox BattleConsole;
        private System.Windows.Forms.Button RoundButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
    }
}