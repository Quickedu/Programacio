using System.Dynamic;
using System.IO.Pipes;
using boxejadors;
using Microsoft.VisualBasic;
namespace boxejadors{
    public class Torneig{
        public int participacions {get;}
        private Random rnd = new ();
        private List <Boxejador> integrans = new ();
        public Boxejador guanyador {get; set;}

        public Torneig(int participants)
        {
            participacions = participants;
        }

        public void noutorneig (){
            Console.WriteLine("Introdueix el nom dels boxejadors que combatran i la resistencia de cadascun (maxim 20, minim 7)");
            for (int i=0 ; i<participacions; i++){
                while (true){
                    Console.WriteLine($"Combatent {i+1}:");
                    var input = Console.ReadLine();
                    if (!int.TryParse(input, out int ok)){
                        if (input!=null){
                            if (!integrans.Any (c => c.nom == input)){
                                while (true){
                                    var hp=0;
                                    Console.WriteLine($"Escriu la resistencia del combatent {i+1}:");
                                    try
                                    {
                                        hp = int.Parse(Console.ReadLine());
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Aixo no és un numero!");
                                        Console.WriteLine("");
                                        continue;
                                    }
                                    if (hp<7||hp>20){
                                        Console.WriteLine($"Numero no admés. {hp} NO es troba entre 7 i 20!");
                                        continue;
                                    }
                                    integrans.Add (new Boxejador (input,hp,i));
                                    break;
                                }
                                break;
                                
                            }
                            Console.WriteLine($"El nom {input} ja existeix.");
                            Console.WriteLine("Torna a introduir el nom del boxejador");
                            Console.WriteLine("");
                            continue;
                        }
                        Console.WriteLine("Si apretes l'enter directament no escrius res.");
                        Console.WriteLine("Introdueix algun valor per referenciar el boxejador.");
                        Console.WriteLine("");
                        continue;
                    }
                    Console.WriteLine($"{input} és un numero! Només es permet entrar el nom del boxejador");
                    Console.WriteLine("Torna a introduir el nom del boxejador");
                    Console.WriteLine("");
                    continue;
                }
            }
            return;
        } 

        public void combat (){ //se que es pot posar tot amb una array guardant box1 i box2 dins de posicio 0 i 1, i anar alternant
        //pero ja tinc tant aquest com el de textvictories fet, i no vull haver-ho de canviar tot :/
            var numcombatent = 0;
            var totalcombats = participacions-1;
            for (int i = 0 ; i<totalcombats ; i++){
                numcombatent = rnd.Next(0,integrans.Count);
                var boxblau = integrans[numcombatent];
                integrans.RemoveAt(numcombatent);
                numcombatent = rnd.Next(0,integrans.Count);
                var boxvermell = integrans[numcombatent];
                integrans.RemoveAt(numcombatent);
                var p1 = boxblau.vida;
                var p2 = boxvermell.vida;
                textcombat (boxblau,boxvermell,i);
                textvictories (boxblau,boxvermell);
                Console.WriteLine("SYSTEM: Per començar el combat, prem la tecla Enter");
                Console.ReadLine();
                Console.WriteLine("QUE COMENÇI EL COMBAT!");
                while(p1!=0 && p2!=0){
                    var r = rnd.Next(0,2);
                    switch (r){
                        case 0:
                        var a = boxvermell.protegirse();
                        var b = boxblau.picar();
                        if (a==b){
                            p2--;
                            Console.WriteLine("COP");
                            Console.WriteLine($"{boxblau.nom} pica i encerta el cop a {boxvermell.nom} a {boxblau.quepica()}");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine($"{boxvermell.nom} s'ha protegit a {boxvermell.onestaprotegit()} i ha parat el cop de {boxblau.nom} a {boxblau.quepica()} amb exit!");
                        break;
                        case 1:
                        a = boxblau.protegirse();
                        b = boxvermell.picar();
                        if (a==b){
                            p1--;
                            Console.WriteLine("COP");
                            Console.WriteLine($"{boxvermell.nom} pica i encerta el cop a {boxblau.nom} a {boxvermell.quepica}");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine($"{boxblau.nom} s'ha protegit a {boxblau.onestaprotegit} i ha parat el cop de {boxvermell.nom} a {boxvermell.quepica} amb exit!");
                        break;
                    }
                }
                if (p1>0) integrans.Insert(boxblau.num,boxblau); else integrans.Insert(boxvermell.num,boxvermell);
                if (integrans.Count>1){
                    Console.WriteLine("I EL COMBAT HA ACABAT!");
                    Console.Write($"El nostre guanyador ha estat ");
                    if(p1>0){
                        Console.WriteLine($"{boxblau.nom}, que ha aguantat un total de {boxblau.vida-p1} cops, quedant-se a {p1} cops de perdre el combat");
                        boxblau.victories++;
                        integrans.Insert(boxblau.num , boxblau);
                    }else {
                        Console.WriteLine($"{boxvermell.nom}, que ha aguantat un total de {boxvermell.vida-p2} cops, quedant-se a {p2} cops de perdre el combat");
                        boxvermell.victories++;
                        integrans.Insert(boxvermell.num , boxvermell);
                    }
                    Console.WriteLine($"SYSTEM: Aquest ha estat el {i+1} combat. Per passar al seguent combat, premi la tecla Enter");
                    Console.ReadLine();                    
                }
            }
            guanyador = integrans[0];
            guanyador.victories++;
            return;
        }

        public void textcombat (Boxejador boxvermell , Boxejador boxblau , int i){
            Console.WriteLine($"Combat numero {i+1}!");
            Console.WriteLine($"Al costat blau, {boxblau.nom}, amb una resistencia de ni més ni menys, {boxblau.vida}!");
            Console.WriteLine($"I al costat vermell, {boxvermell.nom}, amb una resistencia de ni més ni menys, {boxvermell.vida}");
        }
        public void textvictories (Boxejador boxvermell , Boxejador boxblau){
            if (boxvermell.victories!=0 || boxblau.victories!=0){
                Console.WriteLine("A més, comptem amb un combat interesant!");
                if (boxblau.victories!=0 && boxvermell.victories !=0){
                    Console.Write($"Ja que ens trobem amb dos vencedors, dos titans que ja han acumulat victories durant el torneig del dia d'avui!");
                    Console.WriteLine($"Siguent així, que {boxblau.nom} ha acumulat durant el dia d'avui {boxblau.victories} victories!");
                    Console.WriteLine($"I {boxvermell.nom} ha acumulat durant el torneig un total de {boxvermell.victories} victories");
                    return;
                } 
                if (boxblau.victories!=0){
                    Console.WriteLine("Ja que en el costat blau, tenim un combatent que ja ha tastat el gust de la victoria!");
                    Console.WriteLine($"Siguent així, que {boxblau.nom} ha acumulat durant el dia d'avui {boxblau.victories} victories!");
                    return;
                }
                if (boxvermell.victories!=0){
                    Console.WriteLine("Ja que en el costat blau, tenim un combatent que ja ha tastat el gust de la victoria!");
                    Console.WriteLine($"Siguent així, que {boxvermell.nom} ha acumulat durant el dia d'avui {boxvermell.victories} victories!");
                    return;
                }
            }
        }
        
    }
}