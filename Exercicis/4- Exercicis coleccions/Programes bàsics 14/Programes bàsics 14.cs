using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

Dictionary <string, string> path = new();
path.Add ("N","C:\\DAW\\Programació\\4- Exercicis coleccions\\Programes bàsics 14\\tokage.txt");
path.Add ("P","C:\\DAW\\Programació\\4- Exercicis coleccions\\Programes bàsics 14\\tokage-petit.txt");
path.Add ("I","C:\\DAW\\Programació\\4- Exercicis coleccions\\Programes bàsics 14\\tokage-impossible.txt");

Dictionary <string , int> partsCotxe = new();
partsCotxe.Add("vidres",0);
partsCotxe.Add("carrosseria-groga",0);
partsCotxe.Add("rodes",0);
partsCotxe.Add("carrosseria-vermella",0);
partsCotxe.Add("parafangs",0);

int inputGroc = 0;
int inputVermell = 0;
bool ok2 = true;
bool ok3 = true;
bool ok = true;
string input = "0";
string [] doc;
var pathing = "";
var comandes = 0;
int i=0;

while(true){
    if (ok2 && ok3){
        Console.WriteLine ("Indica nombre de cotxes grocs");
        ok = int.TryParse(Console.ReadLine(), out inputGroc);
        if (!ok){
            continue;
        }
    }
    if (ok3){
        Console.WriteLine("Indica nombre de cotxes vermells");
        ok2 = int.TryParse(Console.ReadLine(), out inputVermell);
        if (!ok2){
            continue;
        }
    }
    Console.WriteLine("Indica quina comanda vols analitzar N (normal) , P (petita) , I (impossible)");
    input = Console.ReadLine().ToUpper();
    if (input!="N" && input != "P" && input!="I"){
        ok3=false;
    } else {
        ok3=true;
    }
    if (ok && ok2 && ok3){
        break;
    }
}
pathing = path[input];
doc = File.ReadAllLines(pathing);


for(i=0; i<doc.Length;i++){
    if (esComanda(doc,i)){
        comandes++;
        continue;
    }
    switch (peca(doc,i)){
        case "vidres" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i);
        break;

        case "carrosseria-vermella" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i);
        break;

        case "carrosseria-groga" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i);
        break;

        case "parafangs" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i) ;
        break;

        case "rodes" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i) ;
        break;
    }
    if (calculcotxes(partsCotxe,inputGroc,inputVermell)){
        Console.WriteLine($"Es poden construir els {inputGroc+inputVermell} cotxes en {comandes} comandes.");
        return;
    }
    if (mescomandes(partsCotxe,inputGroc,inputVermell)){
        Console.WriteLine($"No es poden construir els {inputGroc+inputVermell} cotxes. Es necessiten més comandes");
        return;
    }
}
Console.WriteLine($"No es poden construir els {inputGroc+inputVermell} cotxes. Es necessiten més comandes");



bool esComanda (string [] doc, int i){
    var comanda = doc [i].Split(" ");
    if (comanda[0]=="Comanda"){
        return true;
    }
    return false;
}

string peca (string [] doc , int i){
    var linia = doc [i].Split(" ");
    return linia [1];
}

int quantitatpeca (string [] doc , int i){
    var linia = doc [i].Split(" ");
    return int.Parse(linia [0]);
} 

bool mescomandes (Dictionary <string,int> partsCotxes, int inputGroc , int inputVermell){
    for(int i=0; i<doc.Length ; i++){
        switch (peca(doc, i)){
        case "carrosseria-vermella" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i);
        break;

        case "carrosseria-groga" :
        partsCotxe[peca(doc,i)] += quantitatpeca(doc,i);
        break;
        }
    }
    var vermell = partsCotxe["carrosseria-vermella"];
    var grocs = partsCotxe["carrosseria-groga"];
    if (vermell >= inputVermell || grocs >= inputGroc){
        return true;
    }
    return false;
}

bool calculcotxes (Dictionary <string,int> partsCotxes, int inputGroc , int inputVermell){
    var vermell = partsCotxe["carrosseria-vermella"];
    var grocs = partsCotxe["carrosseria-groga"];
    if ((vermell + grocs)*2 <= partsCotxe["vidres"] && (vermell + grocs)*4 <= partsCotxe["parafangs"] && (vermell + grocs)*8 <= partsCotxe["rodes"]){
        return true;
    } 
    return false;
}