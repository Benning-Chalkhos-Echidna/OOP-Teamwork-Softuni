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
            this.BattleMenu = new System.Windows.Forms.TabPage();
            this.RoundButton = new System.Windows.Forms.Button();
            this.BattleConsole = new System.Windows.Forms.RichTextBox();
            this.TabControl.SuspendLayout();
            this.CharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPortrait)).BeginInit();
            this.BattleMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CharacterPanel);
            this.TabControl.Controls.Add(this.BattleMenu);
            this.TabControl.Location = new System.Drawing.Point(13, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(928, 463);
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
            this.CharacterPanel.Size = new System.Drawing.Size(920, 437);
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
            this.CharacterPortrait.Image = global::Project.Properties.Resources.Warrior;
            this.CharacterPortrait.Location = new System.Drawing.Point(3, 3);
            this.CharacterPortrait.Name = "CharacterPortrait";
            this.CharacterPortrait.Size = new System.Drawing.Size(278, 431);
            this.CharacterPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharacterPortrait.TabIndex = 0;
            this.CharacterPortrait.TabStop = false;
            // 
            // BattleMenu
            // 
            this.BattleMenu.Controls.Add(this.BattleConsole);
            this.BattleMenu.Controls.Add(this.RoundButton);
            this.BattleMenu.Location = new System.Drawing.Point(4, 22);
            this.BattleMenu.Name = "BattleMenu";
            this.BattleMenu.Padding = new System.Windows.Forms.Padding(3);
            this.BattleMenu.Size = new System.Drawing.Size(920, 437);
            this.BattleMenu.TabIndex = 1;
            this.BattleMenu.Text = "BattleMenu";
            this.BattleMenu.UseVisualStyleBackColor = true;
            // 
            // RoundButton
            // 
            this.RoundButton.Location = new System.Drawing.Point(611, 401);
            this.RoundButton.Name = "RoundButton";
            this.RoundButton.Size = new System.Drawing.Size(75, 23);
            this.RoundButton.TabIndex = 1;
            this.RoundButton.Text = "Fight";
            this.RoundButton.UseVisualStyleBackColor = true;
            this.RoundButton.Click += new System.EventHandler(this.RoundButton_Click);
            // 
            // BattleConsole
            // 
            this.BattleConsole.Location = new System.Drawing.Point(301, 6);
            this.BattleConsole.Name = "BattleConsole";
            this.BattleConsole.Size = new System.Drawing.Size(304, 418);
            this.BattleConsole.TabIndex = 2;
            this.BattleConsole.Text = "";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 487);
            this.Controls.Add(this.TabControl);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.TabControl.ResumeLayout(false);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPortrait)).EndInit();
            this.BattleMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CharacterPanel;
        private System.Windows.Forms.TabPage BattleMenu;
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
        private System.Windows.Forms.Button RoundButton;
        private System.Windows.Forms.RichTextBox BattleConsole;
    }
}