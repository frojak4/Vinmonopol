using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinmonopol
{
    internal class Adult : User
    {
        public Adult(string name, int age) : base(name, age)
        {
        }


        public override void playGround()
        {
            Console.Clear();
            Console.WriteLine("You are to old to be playing..");
            Console.ReadKey();
        }
    }
}
