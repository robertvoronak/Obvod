using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obvod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Vypocet obsahu trojuholnika");
            Console.Write("Zadaj stranu a v cm: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Zadaj stranu b v cm: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Zadaj stranu c v cm: ");
            c = Int32.Parse(Console.ReadLine());
            Vypocet vyp = new Vypocet();
            
            Console.WriteLine("Obvod trojuholnika ja: {0} cm", vyp.vypocitaj(a,b,c));
            Console.WriteLine("ukonci stlacenim lub. klavesu");
            Console.ReadKey();
        }
    }
}
