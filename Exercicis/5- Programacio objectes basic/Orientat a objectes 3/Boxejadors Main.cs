using boxejadors;
namespace boxejadors;
class program
{
    static void Main (){
        var participants = 0;
        while (true){
            Console.WriteLine("Introdueix el numero de boxejadors que participaran al torneig");
            try
            {
              participants = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Aixo no es un numero!");
                continue;
            }
            break;
        }
        var torneig = new Torneig (participants);
        torneig.noutorneig();
        Console.WriteLine("HA COMENÇAT EL TORNEIG!");
        Console.WriteLine("Recordem que els combats seran totalment aleatoris, i que una derrota, comportara l'eliminació del participant.");
        Console.WriteLine($"Avui comptem amb un total de {torneig.participacions} combatents, per tant farem un total de {torneig.participacions-1} combats!");
        Console.WriteLine("Dit tot això, podem començar el nostre torneig!");
        torneig.combat();
        Console.WriteLine($"I fins aqui el nostre torneig, on el guanyador del torneig final ha estat {torneig.guanyador.nom}, amb resistencia de {torneig.guanyador.vida} i amb un total de {torneig.guanyador.victories} victories durant aquest torneig");
    }
}