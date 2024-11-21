namespace HelloWorld
{
    using System;
    class Program
    {
        static void Main (string [] args)
        {
            var i = 0;
            var guess = 0;
            int cas = int.Parse(Console.ReadLine());
            for (i=0 ; i<cas ; i++){
                guess = int.Parse(Console.ReadLine());
                if (guess%360==0  || guess%180==0){
                    Console.WriteLine("OK");
                } else {
                    Console.WriteLine("BRONCA");
                }
            }
        }

    }
}