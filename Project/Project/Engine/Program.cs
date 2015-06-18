using System;
using System.Windows.Forms;
using Project.Engine.Classes;
using Project.Engine.Form;

namespace Project.Engine
{
    public static class Program
    {

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
