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
        Dictionary<int, string> LocalGreetings;

        public RandomGreeting()
        {
            LocalGreetings = Greetings;
        }

        public void SetDictionary(Dictionary<int, string> greetings)
        {
            LocalGreetings = greetings;
        }

        public string GetRandomGreeting()
        {
            int nextValue = (int)(Math.Round((LocalGreetings.Count() - 1) * r.NextDouble()));

            //bug fix
            string toReturn = LocalGreetings.ElementAt(nextValue).Value;
            LocalGreetings = Greetings;

            return toReturn;

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
