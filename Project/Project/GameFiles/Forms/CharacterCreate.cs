using Project.Engine.Classes;
using System;
using System.Windows.Forms;

namespace Project.Engine.Form
{
    public partial class CharacterCreate : System.Windows.Forms.Form
    {
        public CharacterCreate()
        {
            InitializeComponent();
        }

        private Player.PlayerClass playerClass;
        private EntityGender entityGender;
        private string name;

        private void Mage_Click(object sender, EventArgs e)
        {
            playerClass = Player.PlayerClass.Mage;
        }

        private void Warrior_Click(object sender, EventArgs e)
        {
            playerClass = Player.PlayerClass.Warrior;
        }

        private void Paladin_Click(object sender, EventArgs e)
        {
            playerClass = Player.PlayerClass.Paladin;
        }

        private void Druid_Click(object sender, EventArgs e)
        {
            playerClass = Player.PlayerClass.Druid;
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

        private void button1_Click(object sender, EventArgs e)
        {
            UI.gameType = GameType.OneVsOne;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.gameType = GameType.TwoVsTwo;
        }
    }
}
