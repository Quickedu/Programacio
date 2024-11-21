var par1 = "0";
var par2 = "0";
var par3 = "0";
var mesgran = "0";


Console.WriteLine("Escriu la primera paraula");
par1 =Console.ReadLine();
Console.WriteLine("Escriu la segona paraula");
par2 = Console.ReadLine();
Console.WriteLine("Escriu la tercera paraula");
par3 = Console.ReadLine();

if (par1.Length > par2.Length){
    mesgran = par1;
}else {
    mesgran=par2;
    }
if(mesgran.Length < par3.Length){
    mesgran=par3;
}
Console.WriteLine($"La paraula més llarga és {mesgran}");