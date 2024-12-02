namespace Orientat_objectes_1;
using Orientat_objectes_1;
public class Camio{
    private int pesMaxim;
    private List<Vaca> vaques = new ();
    public Camio(int pes)
    {
        pesMaxim = pes;
    }
    
    public int comptarKilos(){
        var kilos = 0;
        foreach(var unitat in vaques){
            kilos += unitat.Pes;
        }
        return kilos;
    }
    public bool posarvaca (Vaca vaca){
        if (comptarKilos()+vaca.Pes > pesMaxim){
            return false;
        }
        vaques.Add(vaca);
        return true;
    }

    public void TreureVaques(){
        vaques.Clear();
    }

    public int litres(){
        var llet = 0;
        foreach (var unitat in vaques){
            llet += unitat.Litres;
        }
        return llet;
    }
    public string noms(){
        var resultat="";
        foreach(var nom in vaques){
            resultat += nom.Nom + ", ";
        }
        return resultat;
    }
}
