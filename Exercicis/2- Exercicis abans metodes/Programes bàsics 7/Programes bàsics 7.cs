string input = "";
bool ok = false;
int i = 0;
long Pinput = 0;
long mesgran = 0;
string valorfinal = "0";
long Pvalorfinal = 0;
string valorinicial = "";

Console.WriteLine("Introdueix un numero enter per la caixa forta (entre 1 i 18 xifres)");
while(input == "" || !ok){
    input=Console.ReadLine();
    if (input != ""){
        ok = long.TryParse(input , out Pinput);
        if (ok){
            mesgran = Pinput;
            valorfinal=input;
            for (i=1 ; i<=input.Length ; i++){
                valorfinal = $"{valorinicial}{valorfinal.Substring(i)}{valorfinal[i-1]}";
                Pvalorfinal = long.Parse(valorfinal);
                if (Pvalorfinal>mesgran){
                    mesgran=Pvalorfinal;
                }
                valorinicial = valorfinal.Substring(0,i);
            }
            Console.WriteLine($"La combinació per obrir la caixa és {mesgran}");
            return;
        } else {
            Console.WriteLine("Aixo no és un numero (o no es valid)! Introdueix un numero enter (entre 1 i 18 xifres) si us plau.");
        }
    } else {
        Console.WriteLine($"{input}? Aixó no és res. Perque apretes l'Enter? Que intentes, petar-me? Haha, no podras...");
        Console.WriteLine("Va, torna-ho a intentar. Pero aquesta vegada res de tonteries eh, que si no m'enfado.");
        Console.WriteLine("");
        Console.WriteLine(" ");
        Console.WriteLine("Introdueix un numero enter per la caixa forta (entre 1 i 18 xifres)");
    }
}