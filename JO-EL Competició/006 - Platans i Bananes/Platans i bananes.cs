namespace Platans_Bananes
{
    using System;

    class Program
    {
        static void Main()
        {
            var P = 0;
            var B = 0;
            var imput = " ";

            while(imput!="0"){
                imput = Console.ReadLine();
                if(imput=="P"){
                    P ++;
                }
                if(imput=="B"){
                    B ++;
                }
            }
            if(P<B){
                Console.WriteLine("M'agraden les bananes");
            }
            if(P>B){
                Console.WriteLine("M'agraden els platans");
            }
            if (P==B){
                Console.WriteLine("No puc distingir entre un platan i una banana");
            }
        }
    }

}