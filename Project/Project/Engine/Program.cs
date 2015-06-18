using Game;
using Game.CharacterClasses;
using System;
using System.Windows.Forms;

namespace Project
{
    public static class Program
    {
        public static Entity enemyTest = new Warrior(EntityGender.Male, "Enemy");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gameMenu = new GameMenu();
            Application.Run(gameMenu);

        }
        public static GameMenu gameMenu;
    }
}
