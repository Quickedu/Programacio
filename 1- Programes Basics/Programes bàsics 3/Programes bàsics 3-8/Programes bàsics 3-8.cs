var num = 0;
var i = 1;
var hash = 1;
var ok = false;

Console.WriteLine("Introdueix un numero");
ok = int.TryParse(Console.ReadLine() , out num);
if (ok==false){
    Console.WriteLine("Valor introduit incorrecte");
}
for (i=1 ; i<=num ; i++){
    for (hash=1 ; hash<=i ; hash++){
        Console.Write("* ");
    }
    Console.WriteLine("");
}