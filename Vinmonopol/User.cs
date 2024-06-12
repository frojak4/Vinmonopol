using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinmonopol
{
    internal class User
    {
        protected string _name;
        protected int _age;

        public User(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public virtual void buyAlcohol()
        {
            Console.Clear();
            Console.WriteLine("You acquired vodka!!");
            Console.ReadKey();
        }

        public virtual void playGround()
        {
            Console.Clear();
            Console.WriteLine("You're playing in the park. Having a great time!");
            Console.ReadKey();
        }
    }
}
