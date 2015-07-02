using Project.Engine.Form;
using System;
using System.Windows.Forms;

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
