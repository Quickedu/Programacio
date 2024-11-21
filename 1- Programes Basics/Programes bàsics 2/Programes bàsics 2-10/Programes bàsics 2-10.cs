var num1s = "0";
var num2s = "0";
var num3s = "0";
var num1 = 0;
var num2 = 0;
var num3 = 0;
var numdif1 = 0;
var numdif2 = 0;

Console.WriteLine("Escriu el primer numero ");
num1s = Console.ReadLine();
var ok1 = int.TryParse(num1s , out num1);
if (ok1 == false){
    Console.WriteLine ("Aixó no és un numero!");
    return;
}
Console.WriteLine("Escriu el segon numero ");
num2s = Console.ReadLine();
var ok2 = int.TryParse(num2s , out num2);
if (ok2 == false){
    Console.WriteLine ("Aixó no és un numero!");
    return;
}
Console.WriteLine("Escriu el tercer numero ");
num3s = Console.ReadLine();
var ok3 = int.TryParse(num3s , out num3);
if (ok3 == false){
    Console.WriteLine ("Aixó no és un numero!");
    return;
}

numdif1 = Math.Abs(num1-num2);
numdif2 = Math.Abs(num1-num3);

if (numdif1 < numdif2){
    Console.WriteLine($"El numero més proper al numero {num1} és el numero {num2}");
}else {
    Console.WriteLine($"El numero més proper al numero {num1} és el numero {num3}");
}