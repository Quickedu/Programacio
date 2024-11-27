Console.WriteLine ("Escriu un numero de tres xifres: ");
var txt = Console.ReadLine ();
if (txt.Length == 3){
var ok = int.TryParse(txt , out int num);
if (ok == true) {
    int c = (num/100);
    int r = (num%100);
    int d = (r/10);
    int u = (r%10);
    Console.WriteLine ($"{u*100+d*10+c}");
}
}else {Console.WriteLine ("Aixó no es un numero de tres xifres!");}