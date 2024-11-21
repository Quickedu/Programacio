var num = 0;

Console.WriteLine("Escriu una frase");
var input = Console.ReadLine().ToLower();
for(var i=0 ; i<input.Length ; i++){
    if(input[i]=='a' || input[i]=='e' || input[i]=='i' || input[i]=='o' || input[i]=='u'){
        num = num+1;
    }
}
Console.WriteLine($"La frase te {num} vocals.");