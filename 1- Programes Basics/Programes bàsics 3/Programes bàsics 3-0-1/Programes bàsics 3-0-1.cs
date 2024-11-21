var numLinia = 0;

for (int comptador = 1 ; comptador <=100;){
    if(comptador%2 == 1){
        while (numLinia>5){
        Console.Write(comptador + " ");
        numLinia = numLinia ++;
        comptador = comptador++;
        }
    Console.WriteLine();
    numLinia = 0;
    }
}