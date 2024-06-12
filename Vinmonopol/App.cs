using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vinmonopol
{
    internal class App
    {
        private User currentUser;

        public void Run()
        {
            createAccount();

            mainMenu();
        }

        private void createAccount()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                currentUser = new Adult(name, age);
            }
            else
            {
                currentUser = new Child(name, age);
            }
        }

        private void mainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Go to the vinmonopol");
                Console.WriteLine("2. Go to the playground");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        currentUser.buyAlcohol();
                        break;
                    case "2": 
                        currentUser.playGround();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
