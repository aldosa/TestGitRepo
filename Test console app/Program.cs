using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Globalization;
>>>>>>> release/release_branch_for_1.0
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello world!");
        }
    }
=======
            var rig = new RandomInternationalGreeting();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(rig.GetRandomGreeting("English"));

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(rig.GetRandomGreeting("Swahili"));
            
        }

    }

>>>>>>> release/release_branch_for_1.0
}
