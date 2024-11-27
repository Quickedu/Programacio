var numero = "0";
var ok = false;
var num = 0;

Console.WriteLine("Escriu un numero de 3 xifres:");
numero = Console.ReadLine();
if (numero.Length==3){
    ok = int.TryParse(numero , out num);
    if (ok==true){
        if (numero.Substring(0,1)==numero.Substring(2,1)){
            Console.WriteLine($"El numero {num} és capicua");
        }else{
            Console.WriteLine($"El numero {num} no és capicua");
        }
    }else {
        Console.WriteLine("Aixó no és un numero!");
    }
}else {
    Console.WriteLine("Aixó no és un numero de 3 xifres!");
}