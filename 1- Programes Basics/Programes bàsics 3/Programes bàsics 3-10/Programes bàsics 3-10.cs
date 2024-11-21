var i = 0;

Console.WriteLine("Escriu una frase");
var input = Console.ReadLine();
var count = input.Count();
for (i=count ; i>0 ; i--){
    Console.Write(input[i-1]);
}