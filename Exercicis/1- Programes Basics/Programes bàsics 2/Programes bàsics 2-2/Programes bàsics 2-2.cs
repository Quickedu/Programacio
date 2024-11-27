var numero = "0";
float numF = 0;
Console.WriteLine("Entra un numero:");
numero = Console.ReadLine();
var ok = float.TryParse(numero , out numF);
if (numF%2==0){
    Console.WriteLine($"El numero {numero} és parell");
} else {
    Console.WriteLine($"El numero {numero} és senar");
}