int [,] diana = {
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
var jugador1 = 0;
var jugador2 = 0;
Random rnd = new();
var x = 0;
var y = 0;


while (jugador1<50 && jugador1!=jugador2 || jugador2<50 && jugador1!=jugador2 ){
    y = rnd.Next (0,8);
    x = rnd.Next (0,8);
    jugador1 = jugador1+diana[x,y];

    y = rnd.Next (0,8);
    x = rnd.Next (0,8);
    jugador2 = jugador2+diana[x,y];
}