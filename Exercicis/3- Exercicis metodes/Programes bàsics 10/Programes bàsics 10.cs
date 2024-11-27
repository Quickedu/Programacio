string [] path = {
    "C:\\DAW\\Programació\\Programes bàsics 10\\desitjos.txt",
    "C:\\DAW\\Programació\\Programes bàsics 10\\desitjos2.txt"
    };
string [] regals = {
    "Retallable","Escacs","Biberó","Sabates"
    };
var input = 0;
while(true){
    Console.WriteLine("Introdueix el numero de llista que vols comprovar (1 o 2)");
    var ok = int.TryParse(Console.ReadLine(), out input);
    if (input !=1 && input !=2 && !ok){
        Console.WriteLine("No has introduit cap numero o el numero no ha estat correcte");
    }else{
        break;
    }
}
string [] document = File.ReadAllLines(path[input-1]);

foreach (var nom in document){
    if (PucRepartirRegals(regals,nom)){
        Console.WriteLine(AconseguirNom(nom));
    }
}

string AconseguirNom(string nom){
    string [] separat = nom.Split(":");
    return separat[0];
}

bool PucRepartirRegals (string [] document , string nom){
    string [] separa = nom.Split(": ");
    string [] regalets = separa[1].Split(",");
    foreach (var regal in regalets){
        if (ExisteixElRegal(regals , regal)){
            return true;
        }
    }
    return false;
}


bool ExisteixElRegal (string [] regals , string regal){
    foreach (var regaldelsac in regals){
        if (regal == regaldelsac){
            return true;
        }
    }
    return false;
}