var ok = false;
var num = 0;

Console.WriteLine("Entra el numero de casa de l'infant");
Console.WriteLine(num);
ok = int.TryParse(Console.ReadLine() , out num);
Console.WriteLine(num);
if (ok==true){
    if (num>=1 & num<=20) {
        Console.WriteLine("Va al grup vermell");
    }
    if (num>=21 & num<=40){
        Console.WriteLine("Va al grup blau");
    }
    if (num>=41 & num<=60){
        Console.WriteLine("Va al grup verd");
    }
    if (num>=61){
        Console.WriteLine("Va al grup blanc");
    }
}
if (ok==false){
    Console.WriteLine("Aixó no es un numero!!!");
}
