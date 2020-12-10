﻿using System;
using System.IO;

namespace Demo5
{
    class Program
    {
        static int count;
        static StreamReader sr;
        //const string name="c:\\robo/plik1.txt";
        const string name = @"c:\robo/plik1.txt";

        
        static void Main(string[] args)
        {
            count = 0;
            try
            {
                sr = new StreamReader(name);
                ReadLines();
                sr.Close();
                Console.WriteLine($"\nLiczba linii: {count}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Komunikat systemowy: " + e.Message + "\n");
            }
        }

        static void ReadLines()
        {
            String textLine = sr.ReadLine();
            if (textLine != null)
            {
                Console.WriteLine(textLine);
                count++;
                ReadLines();
            }
        }
    }
}
