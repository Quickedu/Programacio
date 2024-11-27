var input = "0";
var num = 9;
var ok = false;
var ok1 = false;
var zeros = (input.Length - 1);
var dosdigits = "0";
var dosdigitsP = 0;
var zeros2 = 0;

Console.WriteLine("Escriu un multiple de 10");
while (num%10!=0 && input.Length<=1 || input.Length<=1){
    input = Console.ReadLine();
    ok = int.TryParse(input , out num);
    if (ok==false){
        Console.WriteLine("No és un numero");    
    }
    if (ok==true && num%10!=0){
        Console.WriteLine("INCORRECTE");
        ok = false;
    }
}
ok1 = int.TryParse(input , out num); 
if (ok1==true){
    for (int i=1 ; i<=zeros ; i++ ) {
        if (input [i]!=0){
            Console.WriteLine("Format de numero no admés");

            return;
        }
    }
    if (input.Length == 2){
        zeros = 1;
    } else {
        zeros2 = input.Length - 1;
    }
} else {
    Console.WriteLine("Format de numero no admés");
    return;
}
dosdigits = input.Substring (0,1);
Console.WriteLine($"CORRECTE {dosdigits} * 10 elevat a {zeros2} és {num}");