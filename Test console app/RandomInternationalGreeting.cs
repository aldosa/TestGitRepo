using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_console_app
{
    class InternationalGreeting : Tuple<string, string>
    {
        public InternationalGreeting(string language, string greeting) : base(language, greeting)
        {

        }
    }


    class RandomInternationalGreeting : RandomGreeting
    {
        Random r = new Random();

        public RandomInternationalGreeting()
            : base()
        {

        }

        public string GetRandomGreeting(string language)
        {
            var greet = Greetings.Where(x => x.Value.Item1 == language);
            if (greet.Count() == 1) return greet.First().Value.Item2;

            if (greet.Count() == 0) return GetRandomGreeting();

            if (greet.Count() > 1)
            {
                Greetings = greet.ToDictionary(x => x.Key, x => x.Value);

                var tempDic = new Dictionary<int, string>();
                Greetings.ToList().ForEach(x => tempDic.Add(x.Key, x.Value.Item2));
                base.SetDictionary(tempDic);

                return GetRandomGreeting();

            }

            throw new NotImplementedException("You should not get here");

        }

        Dictionary<int, InternationalGreeting> Greetings = new Dictionary<int, InternationalGreeting>()
        {
            {0, new InternationalGreeting("English", "Hello world!") },
            {1, new InternationalGreeting("Irish", "Top o' the morning!")},
            {2, new InternationalGreeting("Italian", "Buon Giorno!")},
            {3, new InternationalGreeting("Spanish","¡Buenos Días!")},
            {4, new InternationalGreeting("English", "Hey!")},
            {5, new InternationalGreeting("Australian","G'day, mate!")},
            {6, new InternationalGreeting("French", "Bonjour!")},
        };

    }
}
