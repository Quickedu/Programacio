var planta = 0;
var input = "0";
var document = "0";
var i = 0;
var parada = false;
var llargada = 0;

Console.WriteLine("Indica quin arxiu vols comprovar (1 , 2 , 3)");
input = Console.ReadLine();
if (input == "1"){
    document = File.ReadAllText("C:\\DAW\\Programació\\Programes bàsics 5\\Documents Ascensoristes\\ascensorista01.txt");
    llargada = document.Length;
    for (i=0 ; i<llargada ; i++){
        if (document [i] == 'D'){
            planta= planta -1;
        }
        if (document [i] == 'U'){
            planta = planta +1;
        }
        if (document [i] == '*'){
            if (planta == 1 || planta == 29){
                parada = true;
                Console.WriteLine($"SI, a la planta {planta}");
                return;
            }
        }
    }
}
if (input == "2"){
    document = File.ReadAllText("C:\\DAW\\Programació\\Programes bàsics 5\\Documents Ascensoristes\\ascensorista02.txt");
    llargada = document.Length;
    for (i=0 ; i<llargada ; i++){
        if (document [i] == 'D'){
            planta = planta -1;
        }
        if (document [i] == 'U'){
            planta = planta +1;
        }
        if (document [i] == '*'){
            if (planta == 15){
                parada = true;
                Console.WriteLine($"SI, a la planta {planta}");
                return;
            }
        }
    }
}
if (input == "3"){
    document = File.ReadAllText("C:\\DAW\\Programació\\Programes bàsics 5\\Documents Ascensoristes\\ascensorista03.txt");
    llargada = document.Length;
    for (i=0 ; i<llargada ; i++){
        if (document [i] == 'D'){
            planta = planta -1;
        }
        if (document [i] == 'U'){
            planta = planta +1;
        }
        if (document [i] == '*'){
            if (planta == 72){
                parada = true;
                Console.WriteLine($"SI, a la planta {planta}");
                return;
            }
        }
    }
}
if (parada == false){
    Console.WriteLine("No, no hi ha parat");
}