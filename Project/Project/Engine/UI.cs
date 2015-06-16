using Game.CharacterClasses;
using Game.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game
{
    public static class UI
    {
        //Implement rest of the UI and Menus.
        //We also need to implement a way to save files.
        public static Player Player;
        private static int PlayerIndex = 0;

        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Character name?");
            string charName = Console.ReadLine();
            Console.WriteLine("(M)ale / (F)emale");
            ConsoleKeyInfo key = Console.ReadKey(true);
            EntityGender genderType;
            if (key.KeyChar == 'm') genderType = EntityGender.Male;
            else genderType = EntityGender.Female;
            Console.WriteLine("(W)arrior, (M)age, (D)ruid, or (P)aladin?");
            ConsoleKeyInfo classKey = Console.ReadKey(true);
            switch (classKey.KeyChar)
            {
                case 'w':
                    Player.setCharacter(new Warrior(genderType, charName));
                    UI.Player.Characters.Add(PlayerIndex, UI.Player.Character);
                    PlayerIndex++;
                    break;
                case 'm':
                    Player.setCharacter(new Mage(genderType, charName));
                    UI.Player.Characters.Add(PlayerIndex, UI.Player.Character);
                    PlayerIndex++;
                    break;
                case 'd':
                    Player.setCharacter(new Druid(genderType, charName));
                    UI.Player.Characters.Add(PlayerIndex, UI.Player.Character);
                    PlayerIndex++;
                    break;
                case 'p':
                    Player.setCharacter(new Paladin(genderType, charName));
                    UI.Player.Characters.Add(PlayerIndex, UI.Player.Character);
                    PlayerIndex++;
                    break;
                default:
                    break;
            }

            Msg(Constants.successfulCharCreation);
            Msg(string.Format("{0} - the {1} {2}!",
                UI.Player.Character.Name, UI.Player.Character.EntityGender, UI.Player.Character.GetType().Name));

        }
        public static void PrintLoginScreen()
        {
            Console.Clear();
            Console.WriteLine("(L)ogin / (R)egister");
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.KeyChar)
            {
                case 'l':
                    LoginInput();
                    break;
                case 'r':
                    RegisterInput();
                    break;
                default:
                    break;
            }
        }

        private static void RegisterInput()
        {
            //This should take the input from the console and transfer it to the txt file holding
            //all username and password values.
            Console.Write("Enter new username: ");
            string username = Console.ReadLine();
            Console.Write("\nEnter new password: ");
            string password = Console.ReadLine();

            List<string> input = File.ReadLines("Resources\\usernames.txt").ToList<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string inputLn = input[i];
                string[] pair = inputLn.Split(new char[] { ',', '|' });
                string currentUser = pair[0];
                if (currentUser == username) Msg(Constants.userExists);

            }
            input.Add(username + "|" + password);
            File.WriteAllLines("Resources\\usernames.txt", input);
            //We set the global player to a new player.
            UI.Player = new Player(username, password);
            Msg(Constants.successfulRegister);

        }
        private static void LoginInput()
        {
            //This should check the values if they exist in the database.
            //If they don't, an exception is thrown.
            //If they do, the login succeeds.
            Console.Write("Account Username: ");
            string username = Console.ReadLine();
            Console.Write("\nAccount Password: ");
            string password = Console.ReadLine();

            bool noUserFlag = true;
            bool passMismatchFlag = true;

            List<string> input = File.ReadLines("Resources\\usernames.txt").ToList<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string inputLn = input[i];
                string[] pair = inputLn.Split(new char[] { ',', '|' });
                string currentUser = pair[0];
                if (currentUser == username)
                {
                    noUserFlag = false;
                    string currentPass = pair[1];
                    if (currentPass == password) passMismatchFlag = false;
                }

            }
            if (!noUserFlag && !passMismatchFlag) Msg(Constants.loginWelcome);
            else if (noUserFlag) Msg(Constants.noUserName);
            else if (passMismatchFlag) Msg(Constants.passMismatch);
        }

        public static void Msg(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(2222);
            Engine.Engine eng = new Engine.Engine();
        }
    }
}
