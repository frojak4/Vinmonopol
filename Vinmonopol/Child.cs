using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinmonopol
{
    internal class Child : User
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public override void buyAlcohol()
        {
            Console.Clear();
            Console.WriteLine("You are to young to buy alcohol. The cops are on their way.");
            Console.ReadKey(true);
        }
    }
}
