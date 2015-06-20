using System;
using Project.Engine.Classes;
using Project.Engine.Interfaces;

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
                    if (playerChar.EntityGender.Equals(EntityGender.Male))
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.Druid;
                    else
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.femaleDruid;
                    break;
                case Player.PlayerClass.Warrior:
                    if (playerChar.EntityGender.Equals(EntityGender.Male))
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.Warrior;
                    else
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.femaleWarrior;
                    break;
                case Player.PlayerClass.Paladin:
                    if (playerChar.EntityGender.Equals(EntityGender.Male))
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.Paladin;
                    else
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.femalePaladin;
                    break;
                case Player.PlayerClass.Mage:
                    if (playerChar.EntityGender.Equals(EntityGender.Male))
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.Mage;
                    else
                        this.CharacterPortrait.Image = global::Project.Properties.Resources.femaleMage;
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
            //UI.PassEngagerAndTarget();
            this.BattleConsole.Text += string.Format("\nROUND {0}", UI.roundCounter);
            UI.roundCounter++;
            int nextNum = UI.rnd.Next(1, UI.Enemies.Count);
            while (UI.Enemies[nextNum].isAlive == false)
            { nextNum = UI.rnd.Next(1, UI.Enemies.Count); }
            if (UI.Player.Character.isAlive == true)
            {
                if (UI.Player.Character is IDamage)
                {
                    UI.Round(UI.Player.Character, UI.Enemies[nextNum]);
                    this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Player.Character, UI.Enemies[nextNum]);
                    if (UI.Enemies[nextNum] is IDamage)
                    {
                        UI.Round(UI.Enemies[nextNum], UI.Player.Character);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Enemies[nextNum], UI.Player.Character);
                    }
                    else if (UI.Enemies[nextNum] is IHeal)
                    {
                        int nextOne = UI.rnd.Next(1, UI.Enemies.Count);
                        UI.Round(UI.Enemies[nextNum], UI.Enemies[nextOne]);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Enemies[nextNum],
                            UI.Enemies[nextOne]);
                    }

                }
                else if (UI.Player.Character is IHeal)
                {
                    nextNum = UI.rnd.Next(1, UI.Allies.Count);

                    UI.Round(UI.Player.Character, UI.Allies[nextNum]);
                    if (UI.Allies[nextNum] is IDamage)
                    {
                        UI.Round(UI.Allies[nextNum], UI.Player.Character);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Player.Character, UI.Allies[nextNum]);
                    }
                    else if (UI.Allies[nextNum] is IHeal)
                    {
                        int nextOne = UI.rnd.Next(1, UI.Allies.Count);
                        UI.Round(UI.Allies[nextNum], UI.Allies[nextOne]);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Allies[nextNum],
                            UI.Enemies[nextOne]);
                    }
                }
            }
            else
            {
                //Game Over
            }
        }
    }
}
