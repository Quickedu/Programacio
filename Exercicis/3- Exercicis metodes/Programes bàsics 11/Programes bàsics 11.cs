string [] path = {
    "C:\\DAW\\Programació\\Programes bàsics 11\\carrera1.txt",
    "C:\\DAW\\Programació\\Programes bàsics 11\\carrera2.txt",
    "C:\\DAW\\Programació\\Programes bàsics 11\\carrera3.txt",
    "C:\\DAW\\Programació\\Programes bàsics 11\\carrerasimple.txt", 
    "C:\\DAW\\Programació\\Programes bàsics 11\\carrerasimple2.txt"
};
var tipuscarrera = "";
var input = 0;
string [] document = {};
var s = false;
var marca = 0;
int [] jugadors = {0,0,0,0};
var llargadadocument = 0;
var marcas = 0;

while (true){
Console.WriteLine("Vols analitzar carreres simples o normals? (S/N)");
tipuscarrera = Console.ReadLine().ToLower();
if (tipuscarrera == "s"){
    Console.WriteLine("Indica quin numero de carrera simple vols analitzar (1, 2)");
    var ok = int.TryParse(Console.ReadLine(), out input);
    document=File.ReadAllLines(path[input+2]);
    llargadadocument=document.Length;
    s = true;
    break;
}else if (tipuscarrera == "n"){
        Console.WriteLine("Indica quin numero de carrera normal vols analitzar (1, 2, 3)");
        var ok = int.TryParse(Console.ReadLine(), out input);
        document=File.ReadAllLines(path[input-1]);
        llargadadocument=(document.Length)-1;
        marcas=1;
        break;
    } else {
        Console.WriteLine("No has introduit un valor correcte!");
        }
}

for (marca=marcas;marca<llargadadocument;marca++){
    // var j = (obtenirjugador(document,s,marca) - 1);
    // jugadors [j] = jugadors [j] + obtenirdistancies(document,marca,s);
    // aixo seria per fer-lo més optim/curt, pero volia utilitzar el switch :)
    switch (obtenirjugador(document,s,marca)){
        case 1:
        jugadors [0] = jugadors [0] + obtenirdistancies(document,marca,s);
        break;
        case 2:
        jugadors [1] = jugadors [1] + obtenirdistancies(document,marca,s);
        break;
        case 3:
        jugadors [2] = jugadors [2] + obtenirdistancies(document,marca,s);
        break;
        case 4:
        jugadors [3] = jugadors [3] + obtenirdistancies(document,marca,s);
        break;

    }
}



escriuresposta (jugadors);

void escriuresposta(int [] jugadors)
{
    var guanyador = 0;
    for (int i=0; i<4 ; i++){
        if (guanyador < jugadors [i]){
            guanyador = jugadors [i];
        }
    }
    Console.WriteLine($"Jugador 1 {jugadors [0]}");
    Console.WriteLine($"Jugador 2 {jugadors [1]}");
    Console.WriteLine($"Jugador 3 {jugadors [2]}");
    Console.WriteLine($"Jugador 4 {jugadors [3]}");

    Console.WriteLine($"El jugador guanyador ha sigut {guanyador}");
    return;
}

int obtenirjugador (string [] document, bool s, int marca){
    var jugador = 0;
    jugador = int.Parse(obtenirnumeros(document,marca,s) [0]);
    return jugador;
}

string [] obtenirnumeros (string [] document, int marca , bool s){
    string [] distanciaA;
    string [] distanciaB;
    if (!s){
    distanciaA = document[marca].Split("{ ");
    distanciaB = distanciaA[1].Split(", }");
    distanciaA = distanciaB[0].Split(","); 
    } else {
        distanciaA = document[marca].Split(",");
    }
    return distanciaA;
}

int obtenirdistancies (string [] document , int marca , bool s){
    int mesgran = int.Parse(obtenirnumeros(document,marca,s)[1]);
    int mespetit = int.Parse(obtenirnumeros(document,marca,s)[1]);
    for (int i=1 ; i<=4 ; i++){
        if (mesgran<int.Parse(obtenirnumeros(document,marca,s)[i])){
            mesgran=int.Parse(obtenirnumeros(document,marca,s)[i]);
        }
        if (mespetit>int.Parse(obtenirnumeros(document,marca,s)[i])){
            mespetit=int.Parse(obtenirnumeros(document,marca,s)[i]);
        }
    }

    var distancia = mesgran-mespetit;
    return distancia;
}

//Copyright to github.com/Quickedu