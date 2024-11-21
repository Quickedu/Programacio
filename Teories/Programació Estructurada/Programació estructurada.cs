//public static int //si retorna algun valor posem alguna variable definida (no es pot posar VAR). 
//Si no retorna (o sigui, és null) definim amb *VOID*

//public static int TallaElPa(int mida) //li definim una variable que obtindra valor un cop cridem el metode.
// {
//     return mida; //li diguem que ha de fer quan cridem al metode
// }

//el RETURN significa que el metode retornara amb aquest valor, amb el valor que digui el return



//Exemple amb el joc de la diana:
Random rnd= new();
var p1 = 0;
var p2 = 0;
int r1 = 0;
int r2 = 0;
bool end = false;
int [,] diana = new [,] {
    {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0},
    {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
    {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
    {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
    {0 , 1 , 2 , 5 , 10 , 5 , 2 , 1 , 0},
    {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
    {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
    {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
    {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0}
};
Console.WriteLine("Escriviu els vostres tiros ");
while(!end && (p1 <= 50 || p2 <= 50)){

    p1 = p1 + TiraDard(rnd,diana); //cridem el method i li definim quins valors ha d'obtenir del method
    Console.WriteLine($"Jugador 1 tira a ({r1}, {r2}) - {p1}");
    p2 = p2 + TiraDard(rnd,diana); //cridem el method i li definim quins valors ha d'obtenir del method
    Console.WriteLine($"Jugador 2 tira a ({r1}, {r2}) - {p2}");
if(p1>p2 && p1>=50){
    end = true;
    Console.WriteLine($"Guanya el jugador 1 amb una puntuació de {p1} en contra de {p2} del jugador 2");
    }else if(p2>p1 && p2>=50){
        end = true;
        Console.WriteLine($"Guanya el jugador 2 amb una puntuació de {p2} en contra de {p1} del jugador 1");
        }
}

static int TiraDard(Random rnd , int [,] diana){
    int r1 = rnd.Next(0,8); //hem de definir sempre les variables.
    int r2 = rnd.Next(0,8);
    return diana [r1, r2];
}