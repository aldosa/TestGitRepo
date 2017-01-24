using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_console_app
{
    class RandomGreeting
    {
        Random r = new Random();

        public RandomGreeting()
        {
        }

        public string GetRandomGreeting()
        {
            return Greetings[r.Next(0, 6)];

        }

        Dictionary<int, string> Greetings = new Dictionary<int, string>()
        {
            {0, "Hello world!"},
            {1, "Top o' the morning!"},
            {2, "Buon Giorno!"},
            {3, "¡Buenos Días!"},
            {4, "Hey!"},
            {5, "G'day!"},
            {6, "Bonjour!"},
        };

    }
}
