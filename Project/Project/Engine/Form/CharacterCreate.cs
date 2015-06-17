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
    public partial class CharacterCreate : Form
    {
        public CharacterCreate()
        {
            InitializeComponent();
        }

        private Game.Engine.Player.PlayerClass playerClass;
        private EntityGender entityGender;
        private string name;

        private void Mage_Click(object sender, EventArgs e)
        {
            playerClass = Game.Engine.Player.PlayerClass.Mage;
        }

        private void Warrior_Click(object sender, EventArgs e)
        {
            playerClass = Game.Engine.Player.PlayerClass.Warrior;
        }

        private void Paladin_Click(object sender, EventArgs e)
        {
            playerClass = Game.Engine.Player.PlayerClass.Paladin;
        }

        private void Druid_Click(object sender, EventArgs e)
        {
            playerClass = Game.Engine.Player.PlayerClass.Druid;
        }

        private void Male_Click(object sender, EventArgs e)
        {
            entityGender = EntityGender.Male;
        }

        private void Female_Click(object sender, EventArgs e)
        {
            entityGender = EntityGender.Female;
        }

        private void Unknown_Click(object sender, EventArgs e)
        {
            entityGender = EntityGender.Unknown;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (this.entityGender == EntityGender.Unknown)
            {
                MessageBox.Show("The \"Unknown\" GenderType is just a joke! Select a valid one!");
                Close();
                Application.Restart();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(name) && name.Length != 0)
                {
                    if (name.Length < 3)
                    {
                        MessageBox.Show("Name must be longer than 3 characters!");
                        Close();
                        Application.Restart();
                    }
                    else if (name.Length > 15)
                    {
                        MessageBox.Show("Name must be less than 15 characters!");
                        Close();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Name cannot have null or whitespace value!");
                    Close();
                    Application.Restart();
                }
            }
            UI.CreatePlayer(name, UI.CreateEntity(playerClass, entityGender, name));
            MessageBox.Show("Character Successfully Created!\n" + UI.Player.Character.ToString());
            Close();
        }
    }
}
