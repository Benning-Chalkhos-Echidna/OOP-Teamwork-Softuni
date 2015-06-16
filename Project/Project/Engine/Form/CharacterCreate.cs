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
            UI.CreatePlayer(name, UI.CreateEntity(playerClass, entityGender, name));
            MessageBox.Show(UI.Player.Character.ToString());
            Form form = new Form();
            switch (playerClass)
            {
                case Game.Engine.Player.PlayerClass.Druid:
                    break;
            }
            form.Show();
        }
    }
}
