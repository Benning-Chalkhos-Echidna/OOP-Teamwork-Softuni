using Game;
using Game.CharacterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
            CharacterCreate characterCreate = new CharacterCreate();
            characterCreate.ShowDialog();
            Entity playerChar = UI.Player.Character;

            this.CharacterClassValue.Text = playerChar.EntityClass.ToString();
            this.StrValue.Text = playerChar.Strength.ToString();
            this.AgiValue.Text = playerChar.Agility.ToString();
            this.IntValue.Text = playerChar.Intellect.ToString();

            this.HpValue.Text = playerChar.Health.ToString();
            this.AttValue.Text = playerChar.Attack.ToString();
            this.DefValue.Text = playerChar.Defense.ToString();

            switch (playerChar.EntityClass)
            {
                case Game.Engine.Player.PlayerClass.Druid:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Druid;
                    break;
                case Game.Engine.Player.PlayerClass.Warrior:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Warrior;
                    break;
                case Game.Engine.Player.PlayerClass.Paladin:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Paladin;
                    break;
                case Game.Engine.Player.PlayerClass.Mage:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Mage;
                    break;
            }
            switch (playerChar.EntityGender)
            {
                case EntityGender.Male:
                    this.GenderValue.Text = EntityGender.Male.ToString();
                    break;
                case EntityGender.Female:
                    this.GenderValue.Text = EntityGender.Male.ToString();
                    break;
            }

            this.NameValue.Text = playerChar.Name;
        }

        private void RoundButton_Click(object sender, EventArgs e)
        {
            UI.Round(UI.Player.Character, Program.enemyTest);
            this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Player.Character, Program.enemyTest);

        }
    }
}
