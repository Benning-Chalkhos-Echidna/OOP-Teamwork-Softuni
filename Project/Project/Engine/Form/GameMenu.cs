using System;
using Project.Engine.Classes;

namespace Project.Engine.Form
{
    public partial class GameMenu : System.Windows.Forms.Form
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
                case Player.PlayerClass.Druid:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Druid;
                    break;
                case Player.PlayerClass.Warrior:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Warrior;
                    break;
                case Player.PlayerClass.Paladin:
                    this.CharacterPortrait.Image = global::Project.Properties.Resources.Paladin;
                    break;
                case Player.PlayerClass.Mage:
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
            UI.PassEngagerAndTarget();
            //UI.Round(UI.Player.Character, UI.enemyTest);
            this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Player.Character, UI.enemyTest);

        }
    }
}
