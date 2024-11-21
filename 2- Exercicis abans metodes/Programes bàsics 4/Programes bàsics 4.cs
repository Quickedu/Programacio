Random rnd = new();
int r = rnd.Next(1,99);
var num = 0;
bool ok = false;

Console.WriteLine("Endevina el numero comprés entre 1 i 99 que estic pensant");
while (num != r){
    ok = int.TryParse(Console.ReadLine(), out num);
    if (ok==false){
        Console.WriteLine("Aixó NO és un número!");
        return;
    }
    if (num<r){
        Console.WriteLine("Més gran!");
    } else {
        Console.WriteLine("Més petit!");
    }
}
Console.WriteLine($"Aquest és el meu numero! El {r}");
