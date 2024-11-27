var planta = 0; //mirar la planta a la q esta
string[] doc = { //array amb diferents txt
    "C:\\DAW\\Programació\\Programes bàsics 5\\Documents Ascensoristes\\ascensorista01.txt",
    "C:\\DAW\\Programació\\Programes bàsics 5\\Documents Ascensoristes\\ascensorista02.txt",
    "C:\\DAW\\Programació\\Programes bàsics 5\\Documents Ascensoristes\\ascensorista03.txt"};
var document = "0"; //string amb 100% document
var i = 0; //iteracions
string [,] parada = new string [,] { //on ha de parar
    {"1" , "29"},
    {"15" , null},
    {"72" , null},
    };
var input = 0; //Input del ReadLine amb el num de document
var ok = false;

Console.WriteLine("Indica quin arxiu vols comprovar (1 , 2 , 3)");
ok = int.TryParse(Console.ReadLine() , out input);
if (ok==true && input>= 1 && input<=3){
    document = File.ReadAllText(doc[input-1]);
} else {
    Console.WriteLine("No valid");
}

for (i=0 ; i<document.Length ; i++){
    if (document [i] == 'D'){
        planta = planta -1;
    }
        if (document [i] == 'U'){
        planta = planta +1;
    }
    if (planta==int.Parse(parada[(input-1), 0]) && document [i]== '*' || parada[(input-1), 1]!= null && planta==int.Parse(parada[(input-1), 1]) && document [i]=='*'){
        Console.WriteLine("SI");
        return;
    }
}
Console.WriteLine("NO");