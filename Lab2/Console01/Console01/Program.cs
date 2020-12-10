using System;

namespace Console01
{
    class Program
    {   
        static readonly String name = "Łukasz Kuczma";
        static readonly int id = 17374;

        static void Main(string[] args)
        {
                        
            Console.WriteLine($"Witaj {name} nr indeksu {id}");
            Console.ReadKey();
        }
    }
}
