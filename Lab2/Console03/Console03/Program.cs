using System;
using static System.Console;
using static System.Text.Encoding;

namespace Console03
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-8");
            WriteLine("Witaj, spytam Cię o imię i wiek!");
            Write("Podaj imię: ");
            string name = ReadLine();
            if (name.Length == 0)
            {
                Error.WriteLine("\nBłąd! Nie Poadałeś imienia!\n");
                return;
            }
            Write("Ile masz lat?");
            int age;
            try
            {
                age = System.Convert.ToInt32(ReadLine());
            }
            catch (System.Exception)
            {
                Error.WriteLine("\nBłąd! Nie podałeś liczby całkowitej!");
                return;
            }
            WriteLine($"\nWitaj {name}! \nPodałes, że masz lat: {age:D}\n");
            Read();
        }
    }
}
