﻿using Project.Engine.Classes;
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
                if (UI.Allies.Count == 2)
                {
                    this.allyTwoName.Text = UI.Allies[1].Name + " - Class: " + UI.Allies[1].EntityClass.ToString();
                    if (UI.Allies[1].isAlive)
                    {
                        this.allyTwoStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                            UI.Allies[1].Strength, UI.Allies[1].Agility, UI.Allies[1].Intellect, UI.Allies[1].Attack,
                            UI.Allies[1].Health);
                    }
                    else
                    {
                        this.allyTwoStats.Text = string.Format("Slain");
                    }
                }
                if (UI.Allies.Count == 3)
                {
                    this.allyThreeName.Text = UI.Allies[2].Name + " - Class: " + UI.Allies[2].EntityClass.ToString();
                    if (UI.Allies[2].isAlive)
                    {
                        this.allyThreeStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                            UI.Allies[2].Strength, UI.Allies[2].Agility, UI.Allies[2].Intellect, UI.Allies[2].Attack,
                            UI.Allies[2].Health);
                    }
                    else
                    {
                        this.allyThreeStats.Text = string.Format("Slain");
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
                if (UI.Enemies.Count == 3)
                {
                    this.enemyThreeName.Text = UI.Enemies[2].Name + " - Class: " + UI.Enemies[3].EntityClass.ToString();
                    if (UI.Enemies[2].isAlive)
                    {
                        this.enemyThreeStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                             UI.Enemies[3].Strength, UI.Enemies[0].Agility, UI.Enemies[0].Intellect, UI.Enemies[0].Attack,
                             UI.Enemies[3].Health);
                    }
                    else
                    {
                        this.enemyThreeStats.Text = string.Format("Slain");
                    }
                }
                if (UI.Enemies.Count == 4)
                {
                    this.enemyFourName.Text = UI.Enemies[3].Name + " - Class: " + UI.Enemies[2].EntityClass.ToString();
                    if (UI.Enemies[3].isAlive)
                    {
                        this.enemyFourStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4}  ",
                             UI.Enemies[2].Strength, UI.Enemies[2].Agility, UI.Enemies[2].Intellect, UI.Enemies[2].Attack,
                             UI.Enemies[2].Health);
                    }
                    else
                    {
                        this.enemyFourStats.Text = string.Format("Slain");
                    }
                }
            });
            UI.updateEnemies.Invoke();
        }

        private void RoundButton_Click(object sender, EventArgs e)
        {
            this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Player.Character, UI.Enemies[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Enemies[0]);
        }
    }
}
