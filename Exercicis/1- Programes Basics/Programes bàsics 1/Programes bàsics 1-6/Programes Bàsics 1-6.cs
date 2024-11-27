using System.Globalization;

Console.WriteLine("Escriu un numero:");
var num = Console.ReadLine();
bool ok = float.TryParse(num, CultureInfo.CurrentCulture, out float numdec);
if (ok==true){
    string numSdec = numdec.ToString();
    string numIdec = numSdec;
    int iof = numIdec.IndexOf(",");
    if (iof!=-1) {
            Console.WriteLine($"Numeros Maravellosos: 0{numSdec.Substring(iof)}.");
    }
}else{
    Console.WriteLine("El valor introduit no es un numero, prova un altre cop!");
}