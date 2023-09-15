using System;

namespace InlemningsUppgift2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken lön har person 1?");
            Double Pers1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Vilken lön har person 2?");
            Double Pers2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Vilken lön har person 3?");
            Double Pers3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Medel lönen är " + ((Pers1 + Pers2 + Pers3)/ 3) + "kr");
            Console.ReadKey();
        }
    }
}