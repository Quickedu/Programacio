var nom1 = "0";
var edat1 = "0";
var edat1i = 0;
var nom2 = "0";
var edat2 = "0";
var edat2i = 0;

Console.WriteLine("Escriu un nom:");
nom1 = Console.ReadLine();
Console.WriteLine("Escriu la seva edat");
edat1 = Console.ReadLine();
Console.WriteLine("Escri el segon nom");
nom2 = Console.ReadLine();
Console.WriteLine("Escriu la seva edat");
edat2 = Console.ReadLine();
var ok1 = int.TryParse(edat1 , out edat1i);
var ok2 = int.TryParse(edat2 , out edat2i);

if (edat1i > edat2i){
    Console.WriteLine($"En {nom1} és més gran que {nom2}");
}else {
    Console.WriteLine($"En {nom2} és més gran que {nom1}");
}