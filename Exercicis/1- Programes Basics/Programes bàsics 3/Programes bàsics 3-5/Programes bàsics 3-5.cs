var num = 0;

Console.WriteLine("Escriu una frase");
var input = Console.ReadLine().ToLower();
for(var i=0 ; i<input.Length ; i++){
    if(input[i]=='l' && input[i+1]=='a'){
        num = num+1;
    }
}
Console.WriteLine($"Hi han {num} 'la' en aquesta paraula");