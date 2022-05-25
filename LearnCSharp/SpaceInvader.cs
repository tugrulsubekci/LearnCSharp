using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class SpaceInvader
    {
        static SpaceInvader()
        {
            Console.WriteLine("Aliens detected!");
        }

        public SpaceInvader()
        {
            Console.WriteLine("SpaceInvader instantiated.");
        }

        public static void Beep()
        {
            Console.WriteLine("* beep beep *");
        }
    }
}
