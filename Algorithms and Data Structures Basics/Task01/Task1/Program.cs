using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] goodPhrases = { "Продуктът е отличен.", "Това е страхотен продукт.", "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория." };
            string[] sluchki = { "Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна." };
            string[] firstNames = { "Диана", "Петя", "Стела", "Елена", "Катя" };
            string[] secondName = { "Иванова", "Петрова", "Кирова" };
            string[] cities = { "София", "Пловдив", "Варна", "Русе", "Бургас" };

            Random r = new Random();

            StringBuilder sb = new StringBuilder();
            sb.Append($"{goodPhrases[r.Next(0, goodPhrases.Length)]} {sluchki[r.Next(0, sluchki.Length)]} -- {firstNames[r.Next(0, firstNames.Length)]} {secondName[r.Next(0, secondName.Length)]}, {cities[r.Next(0, cities.Length)]}");

            Console.WriteLine(sb.ToString());
        }
    }
}
