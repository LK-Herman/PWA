using System;
using System.Globalization;
using static System.Console;
using static System.Text.Encoding;

namespace Console02
{
    class Program
    {
    static string ReadName()
        {
            string result = "Witaj ";
            string name = String.Empty;
            Write("Podaj imię:");
            name = ReadLine();
            int len = name.Length;
            if (len != 0) return result + name + "!";
            else return result + "bezimienny";
        }

        static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-8");

            WriteLine("Hello World!");
            WriteLine(ReadName() +"\n");

            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "pl-PL", "en-US", "en-GB", "pt-PT", "de-AT", "ru-RU" };

            foreach(var cultureName in cultureNames )
            {
                var culture = new CultureInfo(cultureName);
                WriteLine("{0}", culture.NativeName);
                WriteLine(" Local date and time {0}, {1:G}", localDate.ToString(culture), localDate.Kind);
                WriteLine(" UTC date and time: {0}, {1:G}\n", utcDate.ToString(culture), utcDate.Kind);
            }
            In.Read();

        }
    }
}
