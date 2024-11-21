var num = 0;
var i = 0;

Console.WriteLine("Escriu una frase");
var input = Console.ReadLine().ToLower().Split(" ");
var count = input.Count();
for (i=0 ; i<count ; i++){
    if (input[i].Substring(0,1)=="a"){
        num = num+1;
    }
}
Console.WriteLine($"Hi ha {num} paraules que comencen per a");