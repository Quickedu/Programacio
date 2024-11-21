string [,] mapa = {
    {"W1","XX","S1","XX","XX","W3","XX"},
    {"N1","XX","E1","S1","XX","XX","E9"},
    {"XX","XX","XX","E1","XX","XX","XX",},
    {"XX","XX","S3","XX","XX","XX","XX",},
    {"E3","XX","XX","S1","XX","XX","XX",},
    {"XX","XX","XX","E2","XX","N5","XX",},
};
int y = 4;
int x = 0;
bool win = false;

while (!win){
    switch (lletra(mapa)){
        case "E":
        x = x+numero(mapa);
        break;
        case "W":
        x = x-numero(mapa);
        break;
        case "S":
        y = +numero(mapa);
        break;
        case "N":
        y = y-numero(mapa);
        break;
        case "X":
        win = true;
        break;
    }
}

Console.WriteLine($"El tresor està a {y},{x}");

string lletra (string [,] mapa){
    var lletra = mapa[y,x].Substring(0,1);
    return lletra;
}

int numero (string [,] mapa){
    var numero = int.Parse(mapa [y,x].Substring(1,1));
    return numero;
}