﻿using Project.Engine.Classes;
using Project.Engine.Interfaces;
using System;
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
            this.entityBindingSource.DataSource = playerChar;


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

            PopulateInformation(playerChar);
            PopulateAiInfo();

            UI.updateAllies = new Action(delegate()
            {
                this.NameValue.Text = playerChar.Name;
                this.label3.Text = UI.Player.Character.Name.ToString() + " - Class: " + UI.Player.Character.EntityClass.ToString();
                this.textBox1.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4},   Mana: {5}  ",
                    UI.Player.Character.Strength, UI.Player.Character.Agility, UI.Player.Character.Intellect, UI.Player.Character.Attack,
                    UI.Player.Character.Health, UI.Player.Character.Mana);

                if (UI.Allies.Count == 1)
                {
                    this.allyOneName.Text = UI.Allies[0].Name + " - Class: " + UI.Allies[0].EntityClass.ToString();
                    if (UI.Allies[0].isAlive)
                    {
                        this.allyOneStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health {4},   Mana: {5}  ",
                            UI.Allies[0].Strength, UI.Allies[0].Agility, UI.Allies[0].Intellect, UI.Allies[0].Attack,
                            UI.Allies[0].Health, UI.Allies[0].Mana);
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
                    this.enemyOneStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3},   Health: {4},   Mana: {5}  ",
                         UI.Enemies[0].Strength, UI.Enemies[0].Agility, UI.Enemies[0].Intellect, UI.Enemies[0].Attack,
                         UI.Enemies[0].Health, UI.Enemies[0].Mana);
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
                        this.enemyTwoStats.Text = string.Format("Strength: {0}   Agility: {1}   Intellect: {2}   Attack: {3}   Health: {4},   Mana: {5}  ",
                             UI.Enemies[1].Strength, UI.Enemies[1].Agility, UI.Enemies[1].Intellect, UI.Enemies[1].Attack,
                             UI.Enemies[1].Health, UI.Enemies[1].Mana);
                    }
                    else
                    {
                        this.enemyTwoStats.Text = string.Format("Slain");
                    }

                }
            });
            UI.updateEnemies.Invoke();
        }

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
        public void PopulateAiInfo()
        {
            DrawEnemyItems();
            if (UI.Allies.Count == 1)
            {
                this.allyWeaponBox.ImageLocation = UI.Allies[0].WeaponImgPath;
                this.allyWeaponTxtBox.Text = UI.Allies[0].equippedItems.Weapon.Name;
                this.allyChestBox.ImageLocation = UI.Allies[0].ChestGearImgPath;
                this.allyChestTxtBox.Text = UI.Allies[0].equippedItems.ChestGear.Name;
                this.allyHeadBox.ImageLocation = UI.Allies[0].HeadGearImgPath;
                this.allyHeadTxtBox.Text = UI.Allies[0].equippedItems.HeadGear.Name;
                this.allyHandsBox.ImageLocation = UI.Allies[0].HandsGearImgPath;
                this.allyHandsTxtBox.Text = UI.Allies[0].equippedItems.HandsGear.Name;
                this.allyLegsBox.ImageLocation = UI.Allies[0].LegsGearImgPath;
                this.allyLegsTxtBox.Text = UI.Allies[0].equippedItems.LegsGear.Name;
            }
        }

        public void DrawEnemyItems()
        {
            this.enemyOneWeaponBox.ImageLocation = UI.Enemies[0].WeaponImgPath;
            this.enemyOneWeaponTxtBox.Text = string.Format("{0}", UI.Enemies[0].equippedItems.Weapon.Name);
            this.enemyOneChestBox.ImageLocation = UI.Enemies[0].ChestGearImgPath;
            this.enemyOneChestTxtBox.Text = string.Format("{0}", UI.Enemies[0].equippedItems.ChestGear.Name);
            this.enemyOneHeadBox.ImageLocation = UI.Enemies[0].HeadGearImgPath;
            this.enemyOneHeadTxtBox.Text = string.Format("{0}", UI.Enemies[0].equippedItems.HeadGear.Name);
            this.enemyOneHandsBox.ImageLocation = UI.Enemies[0].HandsGearImgPath;
            this.enemyOneHandsTxtBox.Text = string.Format("{0}", UI.Enemies[0].equippedItems.HandsGear.Name);
            this.enemyOneLegsBox.ImageLocation = UI.Enemies[0].LegsGearImgPath;
            this.enemyOneLegsTxtBox.Text = string.Format("{0}", UI.Enemies[0].equippedItems.LegsGear.Name);

            if (UI.Enemies.Count == 2)
            {
                this.enemyTwoWeaponBox.ImageLocation = UI.Enemies[1].WeaponImgPath;
                this.enemyTwoWeaponTxtBox.Text = string.Format("{0}", UI.Enemies[1].equippedItems.Weapon.Name);
                this.enemyTwoChestBox.ImageLocation = UI.Enemies[1].ChestGearImgPath;
                this.enemyTwoChestTxtBox.Text = string.Format("{0}", UI.Enemies[1].equippedItems.ChestGear.Name);
                this.enemyTwoHeadBox.ImageLocation = UI.Enemies[1].HeadGearImgPath;
                this.enemyTwoHeadTxtBox.Text = string.Format("{0}", UI.Enemies[1].equippedItems.HeadGear.Name);
                this.enemyTwoHandsBox.ImageLocation = UI.Enemies[1].HandsGearImgPath;
                this.enemyTwoHandsTxtBox.Text = string.Format("{0}", UI.Enemies[1].equippedItems.HandsGear.Name);
                this.enemyTwoLegsBox.ImageLocation = UI.Enemies[1].LegsGearImgPath;
                this.enemyTwoLegsTxtBox.Text = string.Format("{0}", UI.Enemies[1].equippedItems.LegsGear.Name);
            }
        }

        //Attack First Enemy Button
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
            if (!UI.Enemies[0].isAlive)
            {
                this.RoundButton.Enabled = false;
            }
        }
        //Attack Second Enemy Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (UI.hasAttacked)
            {
                this.BattleConsole.Text += "\n You cannot attack or use a spell twice in the same turn!";
            }
            else
            {
                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Player.Character, UI.Enemies[1]);
                UI.hasAttacked = true;
            }

            if (!UI.Enemies[1].isAlive)
            {
                this.button3.Enabled = false;
            }
        }

        //Spell Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (UI.hasAttacked)
            {
                this.BattleConsole.Text += "\n You cannot attack or use a spell twice in the same turn!";
            }
            else if (UI.Player.Character.Mana < UI.Player.Character.EntitySpell.SpellCost)
            {
                this.BattleConsole.Text += "\n Not enough mana!";
            }
            else
            {
                if (UI.gameType == GameType.OneVsOne)
                {
                    if (UI.Player.Character is IHeal)
                    {
                        this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Player.Character);
                    }
                    else
                    {
                        this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Enemies[0]);
                    }
                }
                else
                {
                    if (UI.Player.Character is IHeal)
                    {
                        if (UI.Allies[0].isAlive && UI.Allies[0].Health < UI.Player.Character.Health)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Allies[0]);
                        }
                        else
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Player.Character);
                        }
                    }
                    else
                    {
                        if (UI.Enemies.TrueForAll(enemy => enemy.isAlive))
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Enemies[UI.rnd.Next(0, 2)]);
                        }
                        else if (!UI.Enemies[0].isAlive)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Enemies[1]);
                        }
                        else
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Player.Character, UI.Enemies[0]);
                        }
                    }
                }

                if (!UI.Enemies[1].isAlive)
                {
                    this.button3.Enabled = false;
                }
                if (!UI.Enemies[0].isAlive)
                {
                    this.RoundButton.Enabled = false;
                }

                UI.Player.Character.Mana -= UI.Player.Character.EntitySpell.SpellCost;
            }
        }
        //Turn End Button 
        private void button2_Click(object sender, EventArgs e)
        {
            UI.allEntities.ForEach(entity =>
            {
                if (entity.isAlive)
                {
                    entity.Health += 10;
                    entity.Mana += 15;
                }
            });
            if (UI.Player.Character.isAlive)
            {
                if (UI.Enemies.TrueForAll(entity => !entity.isAlive))
                {
                    //Game Won.
                    MessageBox.Show("GAME WON!");
                    Application.Restart();
                }
            }
            else
            {
                //Game Lost.
                MessageBox.Show("GAME LOST!");
                Application.Restart();
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
            UI.updateAllies();
            UI.updateEnemies();

            if (!UI.Enemies[1].isAlive)
            {
                this.button3.Enabled = false;
            }
            if (!UI.Enemies[0].isAlive)
            {
                this.RoundButton.Enabled = false;
            }
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
                if (UI.Allies[0] is IHeal)
                {
                    if (UI.Player.Character.Health < UI.PlayerMaxHP)
                    {
                        this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Allies[0], UI.Player.Character);
                        UI.Allies[0].Mana -= UI.Allies[0].EntitySpell.SpellCost;
                    }
                    else
                    {
                        if (UI.Enemies[0].isAlive)
                        {
                            if (UI.Enemies[1].isAlive)
                            {
                                if (UI.Enemies[0] is IHeal)
                                {
                                    this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[0]);
                                }
                                else if (UI.Enemies[1] is IHeal)
                                {
                                    this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[1]);
                                }
                                else if (UI.Enemies[0].Health < UI.Enemies[1].Health)
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
                else
                {
                    if (UI.Enemies[0].isAlive)
                    {
                        if (UI.Enemies[1].isAlive)
                        {
                            if (UI.Enemies[0] is IHeal)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[0]);
                            }
                            else if (UI.Enemies[1] is IHeal)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Allies[0], UI.Enemies[1]);
                            }
                            else if (UI.Enemies[0].Health < UI.Enemies[1].Health)
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
                    if (UI.Enemies[0] is IHeal)
                    {
                        if (UI.Enemies[1].isAlive && UI.Enemies[1].Health < UI.EnemyTwoMaxHP)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Enemies[0], UI.Enemies[1]);
                            UI.Enemies[0].Mana -= UI.Enemies[0].EntitySpell.SpellCost;
                        }
                        else
                        {
                            if (UI.Enemies[0].Health < UI.EnemyOneMaxHP)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Enemies[0], UI.Enemies[0]);
                                UI.Enemies[0].Mana -= UI.Enemies[0].EntitySpell.SpellCost;
                            }
                            else
                            {
                                if (UI.Allies[0].isAlive)
                                {
                                    if (UI.Allies is IHeal)
                                    {
                                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Allies[0]);
                                    }
                                    else if (UI.Player.Character is IHeal)
                                    {
                                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Player.Character);
                                    }
                                    else if (UI.Allies[0].Health < UI.Player.Character.Health)
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
                        }
                    }
                    else
                    {
                        if (UI.Allies[0].isAlive)
                        {
                            if (UI.Allies is IHeal)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Allies[0]);
                            }
                            else if (UI.Player.Character is IHeal)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[0], UI.Player.Character);
                            }
                            else if (UI.Allies[0].Health < UI.Player.Character.Health)
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
                    if (UI.Enemies[1] is IHeal)
                    {
                        if (UI.Enemies[0].isAlive && UI.Enemies[0].Health < UI.EnemyOneMaxHP)
                        {
                            this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Enemies[1], UI.Enemies[0]);
                            UI.Enemies[1].Mana -= UI.Enemies[1].EntitySpell.SpellCost;
                        }
                        else
                        {
                            if (UI.Enemies[1].Health < UI.EnemyTwoMaxHP)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleSpell(UI.Enemies[1], UI.Enemies[1]);
                                UI.Enemies[1].Mana -= UI.Enemies[1].EntitySpell.SpellCost;
                            }
                            else
                            {
                                if (UI.Allies[0].isAlive)
                                {
                                    if (UI.Allies is IHeal)
                                    {
                                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Allies[0]);
                                    }
                                    else if (UI.Player.Character is IHeal)
                                    {
                                        this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Player.Character);
                                    }
                                    else if (UI.Allies[0].Health < UI.Player.Character.Health)
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
                        }
                    }
                    else
                    {
                        if (UI.Allies[0].isAlive)
                        {
                            if (UI.Allies is IHeal)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Allies[0]);
                            }
                            else if (UI.Player.Character is IHeal)
                            {
                                this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Player.Character);
                            }
                            else if (UI.Allies[0].Health < UI.Player.Character.Health)
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
                }
                else
                {
                    this.BattleConsole.Text += "\n" + UI.HandleAttack(UI.Enemies[1], UI.Player.Character);
                }
            }
        }
    }
}
