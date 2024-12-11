Random rnd= new();
var p1 = 0;
var p2 = 0;
bool end = false;
int r1 = 0;
int r2 = 0;
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
        int i=1; //nou codi
        p1 = p1 + tirada(rnd,diana,i);
        Console.WriteLine($"{p1}");

        i=2; //nou codi
        p2 = p2 + tirada(rnd,diana,i);
        Console.WriteLine($"{p2}");

if(p1>p2 && p1>=50){
    end = true;
    Console.WriteLine($"Guanya el jugador 1 amb una puntuació de {p1} en contra de {p2} del jugador 2");
    }else if(p2>p1 && p2>=50){
        end = true;
        Console.WriteLine($"Guanya el jugador 2 amb una puntuació de {p2} en contra de {p1} del jugador 1");
        }
}

int tirada (Random rnd, int [,] diana, int i){
    r1 = rnd.Next(0,8);
    r2 = rnd.Next(0,8);
    Console.Write($"Jugador {i} tira a ({r1}, {r2}) - ");
    return diana [r1, r2];
}



// Random rnd= new();
// var p1 = 0;
// var p2 = 0;
// bool end = false;
// int r1 = 0;
// int r2 = 0;
// int [,] diana = new [,] {
//     {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0},
//     {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
//     {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
//     {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
//     {0 , 1 , 2 , 5 , 10 , 5 , 2 , 1 , 0},
//     {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
//     {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
//     {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
//     {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0}
// };
// Console.WriteLine("Escriviu els vostres tiros ");
// while(!end && (p1 <= 50 || p2 <= 50)){
//         r1 = rnd.Next(0,8);
//         r2 = rnd.Next(0,8);
//         p1 = p1 + diana [r1,r2];
//         Console.WriteLine($"Jugador 1 tira a ({r1}, {r2}) - {p1}");

//         r1 = rnd.Next(0,8);
//         r2 = rnd.Next(0,8);
//         p2 = p2 + diana [r1,r2];
//         Console.WriteLine($"Jugador 2 tira a ({r1}, {r2}) - {p2}");

// if(p1>p2 && p1>=50){
//     end = true;
//     Console.WriteLine($"Guanya el jugador 1 amb una puntuació de {p1} en contra de {p2} del jugador 2");
//     }else if(p2>p1 && p2>=50){
//         end = true;
//         Console.WriteLine($"Guanya el jugador 2 amb una puntuació de {p2} en contra de {p1} del jugador 1");
//         }
// }