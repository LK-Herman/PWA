using System;

public readonly struct Fraction
{
    private readonly int l;
    private readonly int m;

    public Fraction(int l, int m)
    {
        if (m == 0)
        {
            throw new ArgumentException("Mianownik nie może być równy zero.", nameof(m));
        }
        this.l = l;
        this.m = m;
    }

    //-----ZADANIE 2 Punkt 2 - metoda skracania ułamka
    public static Fraction Reduct(Fraction x) 
    {
        int l = x.l;
        int m = x.m;
        int i = (l >= m) ? l : m;

        for (; i>0; i--)
        {
            if(l%i == 0 && m%i==0)
            {
                l /= i;
                m /= i;
            }
        }

        return new Fraction(l,m);
    }

    //-----ZADANIE 2 Punkt 3 - metoda zamiany ułamka niewłaściwego na liczbę całkwitą i ułamek właściwy
    public static string Optimize(Fraction x)
    {
        int l = x.l;
        int m = x.m;
        int c;

        if (l >= m || l==0 || m==0)
        {
            c = l / m;
            if (l % m != 0) l = l % m;
            else return new string($"{c}");
                        
            return new string($"{c} {l}/{m}");
        }
        return new string($"{l}/{m}");
    }

    public static Fraction operator +(Fraction a) => Reduct(a);
    public static Fraction operator -(Fraction a) => Reduct(new Fraction(-a.l, a.m));
    public static Fraction operator +(Fraction a, Fraction b)
        => Reduct(new Fraction(a.l * b.m + b.l * a.m, a.m * b.m));
    public static Fraction operator -(Fraction a, Fraction b)
        => Reduct(a + (-b));
    public static Fraction operator *(Fraction a, Fraction b)
        => Reduct(new Fraction(a.l * b.l, a.m * b.m));
    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.l == 0)
        {
            throw new DivideByZeroException();
        }
        return Reduct(new Fraction(a.l * b.m, a.m * b.l));
    }
    public override string ToString() => $"{l}/{m}";
}

public static class OperatorOverloading
{
    //--- ZADANIE 2  Punkt 1 -- Wczytanie ułamka
    public static Fraction SetFraction()
    {
        int l;
        int m;
        bool check;
        string[] frac;
        do
        {
            check = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Wprowadz ułamek (licznik / mianownik): ");
            frac = Console.ReadLine().Split("/");
            try
            {
                l = Convert.ToInt32(frac[0]);
                m = Convert.ToInt32(frac[1]);
                check = true;
            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("To nie jest ułamek. (Przykłady: 1/2, 45/16, 7/8)");
            }
        } while (check==false);
        
        l = Convert.ToInt32(frac[0]);
        m = Convert.ToInt32(frac[1]);

        return Fraction.Reduct(new Fraction(l, m));
    }

    //--- ZADANIE 2  Punkt 4 -- Wyprowadzenie wyników
    public static void GetSolutions(Fraction a, Fraction b)
    {

        Console.WriteLine("\nWYNIKI:\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("a = ");
        Console.WriteLine(Fraction.Optimize(a));
        Console.Write("b = ");
        Console.WriteLine(Fraction.Optimize(b));
        Console.Write("a + b = ");
        Console.WriteLine(Fraction.Optimize(a + b));
        Console.Write("a - b = ");
        Console.WriteLine(Fraction.Optimize(a - b));
        Console.Write("a * b = ");
        Console.WriteLine(Fraction.Optimize(a * b)); 
        Console.Write("a / b = ");
        Console.WriteLine(Fraction.Optimize(a / b));
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void Main()
    {
        var a = OperatorOverloading.SetFraction();
        var b = OperatorOverloading.SetFraction();
        OperatorOverloading.GetSolutions(a, b);
        //d = Fraction.Reduct(d);
        //Console.WriteLine(Fraction.Optimize(Fraction.Reduct(d)));
    }
}