using System;

namespace Zadanie3_CountTypes
{
    class Program
    {
        public static void CountTypes(params object[] _objects)
        {
            int countEvenIntegers = 0;
            int countPositiveFloat = 0;
            int countDouble = 0;
            int countGreater4Strings = 0;
            int countOthers = 0;
            int countAll = 0;

            foreach (var obj in _objects)
            {
                switch (obj.GetType().Name)
                {
                    case "Int32":
                        if (Convert.ToInt32(obj) % 2 == 0) countEvenIntegers++; else countOthers++;
                        break;
                    case "Single":
                        if (Convert.ToSingle(obj) > 0) countPositiveFloat++; else countOthers++;
                        break;
                    case "Double":
                        countDouble++;
                        break;
                    case "String":
                        if (Convert.ToString(obj).Length > 4) countGreater4Strings++; else countOthers++;
                        break;
                    default:
                        countOthers++;
                        break;
                }
                countAll++;
            }
                Console.WriteLine($"Liczby parzyste całkowite:  {countEvenIntegers}");
                Console.WriteLine($"Liczby dodatnie typu float: {countPositiveFloat}");
                Console.WriteLine($"Liczby typu double:         {countDouble}");
                Console.WriteLine($"Napisy > 5 znaków:          {countGreater4Strings}");
                Console.WriteLine($"Inne elementy:              {countOthers}");
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Wszystkie elementy:         {countAll}");
                Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        static void Main(string[] args)
        {
            CountTypes(
                new Exception(), 
                -12,
                "czwartkowy wieczór", 
                10, 
                new bool(), 
                -8.15f,
                13.05, 
                9090708090.405, 
                "czapka", 
                "lis", 
                1.0f, 
                -0.1f, 
                14.8f, 
                "las", 
                "Częstochowa", 
                "Legnica");
        }
    }
}
