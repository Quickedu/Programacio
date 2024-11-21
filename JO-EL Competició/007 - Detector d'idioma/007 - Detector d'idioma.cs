namespace Platans_Bananes
{
    using System;

    class Program
    {
        static void Main()
        {
            var imput = Console.ReadLine().ToUpper();
            switch (imput){
                case "CIAO":
                Console.WriteLine("IT");
                break;
                case "ADIOS":
                Console.WriteLine("ES");
                break;
                case "GOOD BYE":
                Console.WriteLine("UK");
                break;
                case "AU REVOIR":
                Console.WriteLine("FR");
                break;
                case "DOEI":
                Console.WriteLine("NL");
                break;
                case "TSCHUSS":
                Console.WriteLine("DE");
                break;
                default:
                Console.WriteLine("??");
                break;
            }


        }
    }

}