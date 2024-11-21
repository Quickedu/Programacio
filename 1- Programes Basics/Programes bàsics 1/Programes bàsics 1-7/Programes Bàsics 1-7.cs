Console.WriteLine ("Escriu la hora actual:");
var hora = Console.ReadLine ();
Console.WriteLine("Escriu el numero d'hores a incrementar:");
var horaA = Console.ReadLine ();
var ok = float.TryParse(hora , out float horaf);
var ok2 = float.TryParse(horaA , out float horaAf);
if (ok == true){
    if(ok2 == true){
    Console.WriteLine ($"D'aqui {horaA} hores seran les {horaf+horaAf}");
    }
}