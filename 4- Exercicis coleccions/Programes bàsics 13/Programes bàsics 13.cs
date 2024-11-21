Dictionary <string,int> joguines = new ();
List <string> cancelacions = new ();
var llista = File.ReadAllLines("C:\\DAW\\Programació\\4- Exercicis coleccions\\Programes bàsics 13\\blackfriday.txt");
int i = 0;


for (i=0;i<llista.Length;i++){
    if (!demandes(llista, i)){
        cancelacions.Add(nompersona(llista, i));
        continue;
    }
    for (int ii=0; ii<regals(llista,i).Length; ii++){
        if (joguines.ContainsKey(regals(llista,i)[ii])){
            joguines[regals(llista,i)[ii]]++;
        }else{
            joguines.Add(regals(llista,i)[ii],1);
        }
    }
}
print(joguines,cancelacions);

string nompersona(string [] llista, int i){
    string [] qui = llista [i].Split(": ");
    string persona = qui[0];
    return persona;
}

string [] regals (string [] llista, int i){
    string [] que = llista [i].Split(": ");
    var regals1 = que [1];
    var regals = regals1.Split(",");
    return regals;
}

bool demandes (string [] llista, int i){
    var comprovem = llista [i].Split(": ");
    if (comprovem [1] == ""){
        return false;
    }
return true;
}

void print (Dictionary <string, int> joguines, List <string> cancelacions){
    var print = joguines.OrderBy(pair => pair.Value).Select(pair => pair.Key).ToArray();
    var llargada = 0;
    Console.WriteLine("Ordre de regals:");
    for (int i=0 ; llargada<joguines.Count-1 ; i++){
        Console.Write($"{i+1}-");
        for (int ii=0 ; ii<5 ; ii++){
            Console.Write($"{print[(i*5)+ii]}, ");
            llargada++;
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    Console.WriteLine("Cancelacions:");
    for (int ii=0;ii<cancelacions.Count;ii++){
        Console.WriteLine($"{ii+1}- {cancelacions[ii]}");
    }
    Console.WriteLine($"Total Cancelacions: {cancelacions.Count}");
    return;
}