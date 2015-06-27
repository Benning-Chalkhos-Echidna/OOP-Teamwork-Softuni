using System;
using Project.Engine.Classes;
using Project.Engine.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

            this.GoldValue.Text = playerChar.Gold.ToString();

            //this.HeadGearImgBox.Image = Image.FromFile(playerChar.equippedItems.HeadGear.ImgPath);
            //this.ChestGearImgBox.Image = Image.FromFile(playerChar.equippedItems.ChestGear.ImgPath);

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
                    this.GenderValue.Text = EntityGender.Female.ToString();
                    break;
            }

            UI.updateAllies = new Action(delegate()
            {
                this.NameValue.Text = playerChar.Name;
                this.label3.Text = UI.Player.Character.Name.ToString() + " - Class: " + UI.Player.Character.EntityClass.ToString();
                this.textBox1.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                    UI.Player.Character.Strength, UI.Player.Character.Agility, UI.Player.Character.Intellect, UI.Player.Character.Attack,
                    UI.Player.Character.Health);

                if (UI.Allies.Count == 1)
                {
                    this.label4.Text = UI.Allies[0].Name + " - Class: " + UI.Allies[0].EntityClass.ToString();
                    this.textBox2.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                        UI.Allies[0].Strength, UI.Allies[0].Agility, UI.Allies[0].Intellect, UI.Allies[0].Attack,
                        UI.Allies[0].Health);

                }
                if (UI.Allies.Count == 2)
                {
                    this.label5.Text = UI.Allies[1].Name + " - Class: " + UI.Allies[1].EntityClass.ToString();
                    this.textBox3.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                        UI.Allies[1].Strength, UI.Allies[1].Agility, UI.Allies[1].Intellect, UI.Allies[1].Attack,
                        UI.Allies[1].Health);
                }
                if (UI.Allies.Count == 3)
                {
                    this.label6.Text = UI.Allies[2].Name + " - Class: " + UI.Allies[2].EntityClass.ToString();
                    this.textBox4.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                        UI.Allies[2].Strength, UI.Allies[2].Agility, UI.Allies[2].Intellect, UI.Allies[2].Attack,
                        UI.Allies[2].Health);
                }
            });
            UI.updateAllies.Invoke();

            UI.updateEnemies = new Action(delegate()
            {
                this.label7.Text = UI.Enemies[0].Name + " - Class: " + UI.Enemies[0].EntityClass.ToString();
                this.textBox5.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                     UI.Enemies[0].Strength, UI.Enemies[0].Agility, UI.Enemies[0].Intellect, UI.Enemies[0].Attack,
                     UI.Enemies[0].Health);

                if (UI.Enemies.Count == 2)
                {
                    this.label8.Text = UI.Enemies[1].Name + " - Class: " + UI.Enemies[1].EntityClass.ToString();
                    this.textBox6.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                         UI.Enemies[1].Strength, UI.Enemies[1].Agility, UI.Enemies[1].Intellect, UI.Enemies[1].Attack,
                         UI.Enemies[1].Health);

                }
                if (UI.Enemies.Count == 3)
                {
                    this.label9.Text = UI.Enemies[2].Name + " - Class: " + UI.Enemies[2].EntityClass.ToString();
                    this.textBox7.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                         UI.Enemies[2].Strength, UI.Enemies[2].Agility, UI.Enemies[2].Intellect, UI.Enemies[2].Attack,
                         UI.Enemies[2].Health);
                }
                if (UI.Enemies.Count == 4)
                {
                    this.label10.Text = UI.Enemies[3].Name + " - Class: " + UI.Enemies[3].EntityClass.ToString();
                    this.textBox8.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                         UI.Enemies[3].Strength, UI.Enemies[0].Agility, UI.Enemies[0].Intellect, UI.Enemies[0].Attack,
                         UI.Enemies[3].Health);
                }
            });
            UI.updateEnemies.Invoke();
        }

        private void RoundButton_Click(object sender, EventArgs e)
        {
            //UI.PassEngagerAndTarget();
            this.BattleConsole.Text += string.Format("\nROUND {0}", UI.roundCounter);
            UI.roundCounter++;
            int nextNum = UI.rnd.Next(0, UI.Enemies.Count);
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
                        int nextOne = UI.rnd.Next(0, UI.Enemies.Count);
                        UI.Round(UI.Enemies[nextNum], UI.Enemies[nextOne]);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Enemies[nextNum],
                            UI.Enemies[nextOne]);
                    }

                }
                else if (UI.Player.Character is IHeal)
                {
                    nextNum = UI.rnd.Next(0, UI.Allies.Count);

                    UI.Round(UI.Player.Character, UI.Allies[nextNum]);
                    this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Player.Character, UI.Allies[nextNum]);
                    if (UI.Allies[nextNum] is IDamage)
                    {
                        int nextOne = UI.rnd.Next(0, UI.Enemies.Count);
                        UI.Round(UI.Allies[nextNum], UI.Enemies[nextOne]);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Allies[nextNum], UI.Enemies[nextOne]);
                    }
                    else if (UI.Allies[nextNum] is IHeal)
                    {
                        int nextOne = UI.rnd.Next(0, UI.Allies.Count);
                        UI.Round(UI.Allies[nextNum], UI.Allies[nextOne]);
                        this.BattleConsole.Text += "\n" + UI.RoundOutcome(UI.Allies[nextNum],
                            UI.Allies[nextOne]);
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
