namespace Rellotge
{
    using System;
    class Program
    {
        static void Main (string [] args)
        {
            var dades = Console.ReadLine().Split(":");
            int h = int.Parse (dades [0])%12;
            int m = int.Parse (dades [1]);
            int md = (m*6);
            int hd = (h*30) + ((m/12)*6);
            if (Math.Abs(md-hd)<(0.01)){
                Console.WriteLine("SI");
            } else {
                Console.WriteLine("NO");
            }
        }

    }
}