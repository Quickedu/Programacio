namespace Bombons
{
    class Program
    {
        static void Main (string [] args)
        {
            var dades = System.Console.ReadLine().Split (" ");
            int al = int.Parse(dades [0]);
            int bo = int.Parse(dades [1]);
            if (al==bo && al!=0 && bo!=0){
                System.Console.WriteLine("OK");
            }else if(al<bo ){
                System.Console.WriteLine($"OK: {bo-al}");
            }else {
                System.Console.WriteLine($"KO: {al-bo}");
            }

        }

    }
}