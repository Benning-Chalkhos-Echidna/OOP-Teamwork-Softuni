using Project.Engine.Classes;
using Project.Engine.Interfaces;
using System;

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
            this.entityBindingSource.DataSource = playerChar;
            PopulateInformation(playerChar);

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
                    this.allyOneName.Text = UI.Allies[0].Name + " - Class: " + UI.Allies[0].EntityClass.ToString();
                    if (UI.Allies[0].isAlive)
                    {
                        this.allyOneStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                            UI.Allies[0].Strength, UI.Allies[0].Agility, UI.Allies[0].Intellect, UI.Allies[0].Attack,
                            UI.Allies[0].Health);
                    }
                    else
                    {
                        this.allyOneStats.Text = string.Format("Slain");
                    }
                }
            });
            UI.updateAllies.Invoke();

            UI.updateEnemies = new Action(delegate()
            {
                this.enemyOneName.Text = UI.Enemies[0].Name + " - Class: " + UI.Enemies[0].EntityClass.ToString();
                if (UI.Enemies[0].isAlive)
                {
                    this.enemyOneStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                         UI.Enemies[0].Strength, UI.Enemies[0].Agility, UI.Enemies[0].Intellect, UI.Enemies[0].Attack,
                         UI.Enemies[0].Health);
                }
                else
                {
                    this.enemyOneStats.Text = string.Format("Slain");
                }

                if (UI.Enemies.Count == 2)
                {
                    this.enemyTwoName.Text = UI.Enemies[1].Name + " - Class: " + UI.Enemies[1].EntityClass.ToString();
                    if (UI.Enemies[1].isAlive)
                    {
                        this.enemyTwoStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                             UI.Enemies[1].Strength, UI.Enemies[1].Agility, UI.Enemies[1].Intellect, UI.Enemies[1].Attack,
                             UI.Enemies[1].Health);
                    }
                    else
                    {
                        this.enemyTwoStats.Text = string.Format("Slain");
                    }

                }
            });
            UI.updateEnemies.Invoke();
        }
<<<<<<< HEAD
        //Attack Button
=======

        private void PopulateInformation(Entity playerChar)
        {
            this.WeaponNameBox.Text = playerChar.equippedItems.Weapon.Name;
            this.WeaponStatsTxtBox.Text = string.Format("Strength +{0}, Agility +{1}, Intellect +{2}, HP +{3}",
                playerChar.equippedItems.Weapon.StrModifier, playerChar.equippedItems.Weapon.AgiModifier,
                playerChar.equippedItems.Weapon.IntModifier, playerChar.equippedItems.Weapon.HPModifier);
            this.HeadGearNameBox.Text = playerChar.equippedItems.HeadGear.Name;
            this.HeadGearStatsTxtBox.Text = string.Format("Strength +{0}, Agility +{1}, Intellect +{2}, HP +{3}",
                playerChar.equippedItems.HeadGear.StrModifier, playerChar.equippedItems.HeadGear.AgiModifier,
                playerChar.equippedItems.HeadGear.IntModifier, playerChar.equippedItems.HeadGear.HPModifier);
            this.ChestGearNameBox.Text = playerChar.equippedItems.ChestGear.Name;
            this.ChestGearStatsTxtBox.Text = string.Format("Strength +{0}, Agility +{1}, Intellect +{2}, HP +{3}",
                playerChar.equippedItems.ChestGear.StrModifier, playerChar.equippedItems.ChestGear.AgiModifier,
                playerChar.equippedItems.ChestGear.IntModifier, playerChar.equippedItems.ChestGear.HPModifier);
            this.HandsGearNameBox.Text = playerChar.equippedItems.HandsGear.Name;
            this.HandsGearStatsTxtBox.Text = string.Format("Strength +{0}, Agility +{1}, Intellect +{2}, HP +{3}",
                playerChar.equippedItems.HandsGear.StrModifier, playerChar.equippedItems.HandsGear.AgiModifier,
                playerChar.equippedItems.HandsGear.IntModifier, playerChar.equippedItems.HandsGear.HPModifier);
            this.LegsGearNameBox.Text = playerChar.equippedItems.LegsGear.Name;
            this.LegsGearStatsTxtBox.Text = string.Format("Strength +{0}, Agility +{1}, Intellect +{2}, HP +{3}",
                playerChar.equippedItems.LegsGear.StrModifier, playerChar.equippedItems.LegsGear.AgiModifier,
                playerChar.equippedItems.LegsGear.IntModifier, playerChar.equippedItems.LegsGear.HPModifier);

            this.equippedStrModLabel.Text = "+" + playerChar.equippedItems.EquippedItemsStrModifier.ToString();
            this.equippedAgiModLabel.Text = "+" + playerChar.equippedItems.EquippedItemsAgiModifier.ToString();
            this.equippedIntModLabel.Text = "+" + playerChar.equippedItems.EquippedItemsIntModifier.ToString();
            this.equippedHPModLabel.Text = "+" + playerChar.equippedItems.EquippedItemsHPModifier.ToString();
        }

>>>>>>> f55773d16a0455326b41114676e1b0d712e52644
        private void RoundButton_Click(object sender, EventArgs e)
        {
            if (UI.hasAttacked)
            {
                this.BattleConsole.Text += "\n You cannot attack or use a spell twice in the same turn!";
            }
            else
            {
                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Player.Character, UI.Enemies[0]);
                UI.hasAttacked = true;
            }

        }
        //Spell Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (UI.hasAttacked)
            {
                this.BattleConsole.Text += "\n You cannot attack or use a spell twice in the same turn!";
            }
            else
            {
                this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Enemies[0]);
                UI.hasAttacked = true;
            }
        }
        //Turn End Button 
        private void button2_Click(object sender, EventArgs e)
        {
            if (UI.Player.Character.isAlive)
            {
                if (UI.Enemies.TrueForAll(entity => !entity.isAlive))
                {
                    //Game Won.
                }
            }
            else
            {
                //Game Lost.
            }
            UI.hasAttacked = false;
            EnemyOneMove();
            if (UI.gameType == GameType.TwoVsTwo)
            {
                AllyOneMove();
                EnemyTwoMove();
            }
            this.BattleConsole.Text += "\n\nEnd of round " + UI.RoundCount + "\n";
            UI.RoundCount++;
        }

        //Methods for the A.I.
        private void AllyOneMove()
        {
            if (UI.Allies[0].isAlive != true)
            {
                return;
            }
            else
            {
                if (UI.Enemies[0].isAlive)
                {
                    if (UI.Enemies[1].isAlive)
                    {
                        if (UI.Enemies[0].Health < UI.Enemies[1].Health)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[0]);
                        }
                        else
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[1]);
                        }
                    }
                    else
                    {
                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[0]);
                    }
                }
                else
                {
                    this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[1]);
                }
            }
        }
        private void EnemyOneMove()
        {
            if (UI.Enemies[0].isAlive != true)
            {
                return;
            }
            else
            {
                if (UI.gameType == GameType.TwoVsTwo)
                {
                    if (UI.Allies[0].isAlive)
                    {
                        if (UI.Allies[0].Health < UI.Player.Character.Health)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Allies[0]);
                        }
                        else
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Player.Character);
                        }
                    }
                    else
                    {
                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Player.Character);
                    }
                }
                else
                {
                    this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Player.Character);
                }
            }
        }
        private void EnemyTwoMove()
        {
            if (UI.Enemies[1].isAlive != true)
            {
                return;
            }
            else
            {
                if (UI.gameType == GameType.TwoVsTwo)
                {
                    if (UI.Allies[0].isAlive)
                    {
                        if (UI.Allies[0].Health < UI.Player.Character.Health)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Allies[0]);
                        }
                        else
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Player.Character);
                        }
                    }
                    else
                    {
                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Player.Character);
                    }
                }
                else
                {
                    this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Player.Character);
                }
            }
        }
    }
}
