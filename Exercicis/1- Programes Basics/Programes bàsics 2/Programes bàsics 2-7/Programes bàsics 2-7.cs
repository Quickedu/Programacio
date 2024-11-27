var r1s = "0";
var r1 = 0;
var r2s = "0";
var r2 = 0;
var ok1 = false;
var ok2 = false;

Console.WriteLine("Introdueix el resultat del FC Vilamongat: ");
r1s = Console.ReadLine();
Console.WriteLine("Introdueix el resultat del UE Fontverda: ");
r2s = Console.ReadLine();

ok1=int.TryParse(r1s , out r1);
ok2=int.TryParse(r2s , out r2);

if (ok1==true & ok2==true ){
    if(r1<r2){
        Console.WriteLine($"Gran partit de la UE Fontverda que ha superat al FC Vilamongat per {r2} a {r1}.");
    }
    if (r2<r1){
        Console.WriteLine($"Gran partit del Vilamontgat que ha superat a la UE Fontverda per {r1} a {r2}");
    }
    if (r1==r2){
        Console.WriteLine($"Partit molt igualat entre els dos rivals que ha acabat en empat {r1} a {r2} tot i els esforços dels dos equips")
    }
}
else{
    Console.WriteLine("Resultat no valid");
}