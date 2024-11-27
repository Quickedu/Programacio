var num = 0;
var input = "0";
var Linput = "0";
var i = 0;

Console.WriteLine("Escriu una frase a codificar");
input = Console.ReadLine();
Linput = input.ToLower();
if (input!=null){
    num = input.Count();
    for (i=0 ; i<num ; i++){
        if (Linput [i]!='u' && Linput [i]!='s' && Linput [i]!='a'){
            Console.Write(input[i]);
        }
    }
}