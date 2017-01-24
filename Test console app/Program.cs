using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var rg = new RandomGreeting();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(rg.GetRandomGreeting());
        }
    }
}
