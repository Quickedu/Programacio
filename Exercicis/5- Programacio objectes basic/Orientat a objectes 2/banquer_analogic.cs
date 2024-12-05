using System.Runtime.InteropServices.Marshalling;
using Banquer_analogic;
namespace Banquer_analogic;
public class Program
{
    static void Main(){
        var input = "";
        var banquer = new Banquer ();
        while (input!="sortir" && input!="4"){
            Console.WriteLine("Quina operació vols realitzar? (Introdueix el numero o el nom de l'operació))");
            Console.WriteLine("1- Client nou");
            Console.WriteLine("2- Accedir a client");
            Console.WriteLine("3- Llista clients");
            Console.WriteLine("4- Sortir");
            input = Console.ReadLine().ToLower();
            if (input=="client nou" || input=="1"){
                banquer.nouclient();
            } 
            if (input=="2" || input=="accedir a client"){
                banquer.accedirclient();
            }
            if (input=="3" || input=="llista clients"){
                    banquer.llista();
            } 
            if (input!="client nou" && input!="1" && input!="2" && input!="accedir a client" && input!="3" && input!="llista clients" && input!="4" && input!="sortir") {
                Console.WriteLine("Input no correcte");
                Console.WriteLine("");
                }
        }
        Console.WriteLine("Gracies per utilitzar Bancalogic, esperem que les seves operacions hagin sigut exitoses!");
        Console.WriteLine("Fins aviat!");
    }    
}