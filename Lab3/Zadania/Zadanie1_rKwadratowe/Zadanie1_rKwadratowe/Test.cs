using System;

using System.Collections.Generic;
using System.Text;

namespace Zadanie1_rKwadratowe
{
    class Test
    {
        public static double a, b, c;
        public static void info()
        {
            Console.WriteLine("\nŁukasz Kuczma 17374 / {0}", Environment.MachineName,"\n");
         }

        public static void input_data()
        {
            string str;

            Console.WriteLine("WPROWADŹ a,b,c");
            do
            {
                Console.WriteLine("\nPodaj a: ");
                str = Console.ReadLine();
            } while (!double.TryParse(str, out a));
            do
            {
                Console.WriteLine("\nPodaj b: ");
                str = Console.ReadLine();
            } while (!double.TryParse(str, out b));
            do
            {
                Console.WriteLine("\nPodaj c: ");
                str = Console.ReadLine();
            } while (!double.TryParse(str, out c));
        }

        static void Main(string[] args)
        {
            input_data();
            MyEquation myEq = new MyEquation(a,b,c);
            myEq.findX(myEq.checkDelta());
            switch (myEq.GetFlag())
            {
                case 0:
                    {
                        Console.WriteLine("Brak pierwiastków");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("1 pierwiastek: {0,6:f}", myEq.GetX1());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("2 pierwiastki: {0,6:f} / {1,6:f} ", myEq.GetX1(), myEq.GetX2());
                        break;
                    }
                default:
                    Console.WriteLine("To nie jest równanie kwadratowe!");
                    break;
            }
            info();
        }

    }
}
