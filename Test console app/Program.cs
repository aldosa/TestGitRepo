using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var rig = new RandomInternationalGreeting();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(rig.GetRandomGreeting("English"));

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(rig.GetRandomGreeting("Swahili"));
            
        }

    }

}
