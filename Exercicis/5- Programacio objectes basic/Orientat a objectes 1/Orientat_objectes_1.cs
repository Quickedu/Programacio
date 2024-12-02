using Orientat_objectes_1;
namespace Orientat_objectes_1;
class program
{
    static void Main(){
        //definir variables
        var camio = new Camio(700);
        List<Vaca> vaques = new (){
            new Vaca("Maria",360,40),
            new Vaca("Pepa",250,35),
            new Vaca("Flor",400,43),
            new Vaca("Toñi",180,28),
            new Vaca("Conxita",50,12),
            new Vaca("Blanca",90,13),
        };

        int lletmaxima = 0;
        string noms = "0";

        foreach (var vaca in vaques){
            if (!camio.posarvaca(vaca))
            {
                if (camio.litres()> lletmaxima){
                    lletmaxima=camio.litres();
                    noms = camio.noms();
                }
                camio.TreureVaques();
                camio.posarvaca(vaca);
            }
        }
        Console.WriteLine($"Podem enviar les vaques: {noms}");
    }
}