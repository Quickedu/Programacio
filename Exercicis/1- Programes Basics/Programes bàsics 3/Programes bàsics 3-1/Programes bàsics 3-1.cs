var numeros = 10;

Console.WriteLine("Vols utilitzar el For o el While? Answer F/W");
var ok = Console.ReadLine();
if (ok=="F"){
    for (int i=10 ; i>=0 ; i--){
        Console.WriteLine(i);
    }
}else if(ok=="W"){
    while(numeros >=0){
    Console.WriteLine(numeros);
    numeros --;
}}else {
    Console.WriteLine("Aquesta opció no és valida!");
}