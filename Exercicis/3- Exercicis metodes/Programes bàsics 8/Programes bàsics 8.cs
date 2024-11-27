var butlleta = CreaButlleta();
ImprimeixButlleta(butlleta);

static void ImprimeixButlleta(int[,] butlleta){
    for (int i=0 ; i<9 ; i++){
        Console.Write(" ___ ");
    }
    Console.WriteLine("");
    for (int i=0 ; i<3 ; i++){
        for (int j=0 ; j<9 ; j++){
            if (butlleta [i,j] == 0){
                Console.Write("| XX ");
            }
            if (butlleta [i,j]!=0){
                Console.Write($"| {butlleta[i,j]} ");
            }            
        }
        Console.Write("|");
        Console.WriteLine("");
        for (int j=0 ; j<9 ; j++){
            Console.Write(" --- ");
            }
        Console.Write("|");
        Console.WriteLine("");
    }
}


static int[,] CreaButlleta(){
    int [,] butlleta = {
        {0, 0, 0, 0, 0, 0, 0, 0, 0,},
        {0, 0, 0, 0, 0, 0, 0, 0, 0,},
        {0, 0, 0, 0, 0, 0, 0, 0, 0,},
    };
    for (int i=0 ; i<3; i++){
        EmplenaFila(i, butlleta);
    }
    return butlleta;
}

static void EmplenaFila (int fila, int [,] butlleta){
    var numerosPosats = 0;
    while (numerosPosats<5){
        var num = GeneraUnNumero();
        if (NoNumeroDeDesena(num, fila, butlleta) && NumeroNoButlleta(num, butlleta)){
            var columna = (num / 10);
            if (columna==9) columna = 8;
            butlleta[fila, columna] = num;
            numerosPosats++;
        }
    }
}

static bool NumeroNoButlleta(int num, int[,] butlleta)
{
    var columna = num/10;
    if (columna==9) columna=8;
    for (int i=0 ; i<3 ; i++) {
        if (butlleta [i,columna] == num) return false;
    } return true;
}

static bool NoNumeroDeDesena(int num, int fila, int [,] butlleta)
{
    var columna = num/10;
    if (columna==9) columna = 8;
    if (butlleta[fila, columna] !=0) return false;
    return true;
}

static int GeneraUnNumero()
{
    Random random = new ();
    var num = random.Next(1,90);
    return num;
}