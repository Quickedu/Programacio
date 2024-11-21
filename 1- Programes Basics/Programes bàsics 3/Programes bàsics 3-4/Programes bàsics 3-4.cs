var num = 0;
var sum = 0;
var total = 0;
var ok = false;
var i = 0;

Console.WriteLine("Escriu un numero");
ok = int.TryParse (Console.ReadLine() , out num) ;
if (ok==false) {
    Console.WriteLine("No has escrit un numero!");
    return;
}
for ( i=0; i!=num ; i++){
        sum=sum+1;
        total=total+sum;
}
Console.WriteLine($"La suma és {total}");