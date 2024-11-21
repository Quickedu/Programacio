namespace Escales_Graus_Comerciants
{
    using System;

    class Program
    {
        static void Main()
        {
            var dades = Console.ReadLine().Split(" ");
            int X = int.Parse(dades[0]);
            int y = int.Parse(dades[1]);
            
                if (X==0 && y == 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                double T = (double)X / (1 - y);
                if (y >= 1 && X <= 0 || y==1 && X==1)
                {
                    Console.WriteLine("KO");
                }
                else
                {
                    Console.WriteLine($"{T:F6}");
                }
            }
        }
    }

}