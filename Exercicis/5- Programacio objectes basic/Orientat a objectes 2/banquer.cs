using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;
using Banquer_analogic;
namespace Banquer_analogic{
    public class Banquer{
        private List <Client> clients = new ();
        public Client client {get; set;}
        private string input;

        public Banquer()
        {
        }
        public void nouclient (){
            var ok=false;
            Console.WriteLine("Introdueix les dades del nou client separats amb una coma (numero de client,diners,nom persona)");
            while (!ok){
                var inputS = Console.ReadLine().Split(",");
                try
                {
                    var numclient = 0;
                    var diners = 0;
                    var nom = "";
                    try {
                        numclient = int.Parse(inputS[0]);
                        diners = int.Parse(inputS[1]);
                        nom = inputS[2];
                    }
                        catch(IndexOutOfRangeException){
                        Console.WriteLine("Format no correcte. Torna a introduir el client");
                        continue;
                    }
                    numclient = int.Parse(inputS[0]);
                    diners = int.Parse(inputS[1]);
                    nom = inputS[2];
                    if (clients.Any(c => c.numero == numclient)){
                        var ids = "";
                        ids += numclient;
                        Console.WriteLine("Aquest client ja existeix! Introdueix un ID diferent.");
                        Console.WriteLine($"Introdueix les dades del nou client separats amb una coma i sense utilitzar {ids} (numero de client,diners,nom persona)");
                        continue;
                    }
                    var client = new Client(numclient, diners, nom);
                    clients.Add(client);
                    ok=true;
                    Console.WriteLine($"Client creat amb exit. {numclient} - {nom}, {diners}$");
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format no correcte. Torna a introduir el client");
                }                 
            }
            return;
        }
        public void sumadiners (int ingres, Client target){
            if (target!=null){
                target.saldo += ingres;
                Console.WriteLine($"S'han retirat {ingres} diners. Tens {target.saldo} diners al teu compte");
                return;
            }
        }

        public void restadiners (int retirada, Client target){
            if (target!=null){
                if ((target.saldo - (retirada+(retirada/100)))<0){
                    Console.WriteLine("No es pot realitzar aquesta operació. No tens diners suficients!");
                    return;
                }
                target.saldo -= retirada+(retirada/100);
                Console.WriteLine($"S'han retirat {retirada} diners. Tens {target.saldo} diners al teu compte");
                return;
            }
            Console.WriteLine("Aquest client no existeix");
        }

        public void accedirclient (){
            var num=false;
            while (!num){
                Console.WriteLine("Introdueix el numero identificatiu del client. En cas que no el sapigues, pots consultar la llista escribint \"llista clients\"");
                while (true){
                    input = Console.ReadLine().ToLower();
                    if (input=="llista clients"){
                            llista();
                            Console.WriteLine("Introdueix el numero identificatiu del client.");
                            continue;
                    }
                    break;
                }
                var id = int.Parse(input);
                Client target = clients.FirstOrDefault(c => c.numero == id);
                if (target != null){  
                    num = true;
                    while (true){
                    Console.WriteLine("Indica quina operacio vols realitzar. \" consultar saldo, treure diners, posar diners, sortir\"");
                    input = Console.ReadLine();
                    if (input == "consultar saldo" || input == "saldo" || input == "consultar"){
                        Console.WriteLine($"Tens {target.saldo} diners");
                    continue;
                    }
                    if (input == "treure diners" || input == "treure"){
                        Console.WriteLine("Indica la quantitat a treure");
                        var retirada=int.Parse(Console.ReadLine());
                        restadiners(retirada, target);
                    }
                    if (input == "posar diners" || input == "posar"){
                        Console.WriteLine("Indica la quantitat a posar");
                        var ingres = int.Parse(Console.ReadLine());
                        sumadiners(ingres, target);
                    }
                    if (input == "sortir"|| input == "exit"){
                        Console.WriteLine("Sortint de l'usuari");
                        break;
                    } 
                    if (input != "sortir" && input != "exit" && input != "posar diners" && input != "posar" && input != "treure diners" && input != "treure" && input != "consultar saldo" && input != "saldo" && input != "consultar") {
                        Console.WriteLine("Aquesta comanda no existeix!");
                        }
                    }
                } else {
                        Console.WriteLine("Aquest client no existeix!");
                    }
            }
        }
        public void llista (){
            foreach(Client client in clients){
                Console.WriteLine($"{client.numero} - {client.nompersona}, {client.saldo}$");
            }
            Console.WriteLine("Done");
            Console.WriteLine("");
        }
    }
}