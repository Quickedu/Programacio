Console.WriteLine("Escriu una data");
var dataescrita = Console.ReadLine();
if(dataescrita.Length==8){
    Console.WriteLine(dataescrita.Substring(0,2) + "/" + dataescrita.Substring(2,2) + "/" + dataescrita.Substring(4,4));}
    else
    {
        Console.WriteLine("Aixó no es una data valida. Si us plau, escriu una data de 8 digits");
    }
    