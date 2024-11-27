Console.WriteLine ("Escriu la teva nota:");
var line = Console.ReadLine();
var ok = float.TryParse(line , out float nota);
if (ok==true & nota>=0 & nota<=10 & line.Length<=2){
    if(nota>=5){
        Console.WriteLine("Has estat aprovat!");
    }else{
        Console.WriteLine("Has suspés.");
    }
}else {
    Console.WriteLine("Aquesta nota no es valida. Introdueix un numero entre el 0 i el 10!");
}