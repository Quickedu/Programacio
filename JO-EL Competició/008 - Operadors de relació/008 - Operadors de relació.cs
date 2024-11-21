namespace Platans_Bananes
{
    using System;

    class Program
    {
        static void Main()
        {
           var num = Console.ReadLine().Split(" ");
           long num0 = long.Parse(num[0]);
           long num1 = long.Parse(num[1]);
           if (num0>num1){
            Console.WriteLine(">");
           }
           if (num0<num1){
            Console.WriteLine("<");
           }
           if (num0==num1){
            Console.WriteLine("=");
           }
        }
    }

}