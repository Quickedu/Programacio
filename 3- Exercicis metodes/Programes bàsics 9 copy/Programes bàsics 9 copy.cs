var casc = 0;
var escut = 0;
var Llança = 0;
var Espasa = 0;
var Armadura = 0;
int [] lluitadors = {0,0,0};
string [] armes = {
"Casc","Casc","Escut","Llança","Llança","Escut","Escut","Espasa","Escut","Escut","Casc","Casc","Casc","Escut","Escut","Escut","Espasa","Escut","Espasa","Escut","Escut","Espasa","Espasa","Llança","Escut","Escut","Casc","Espasa","Armadura","Espasa","Espasa","Escut","Escut","Armadura","Armadura","Espasa","Espasa","Espasa","Casc","Escut","Llança","Casc","Llança","Escut","Espasa","Armadura","Llança","Escut","Espasa","Espasa","Escut","Escut","Llança","Casc","Casc","Escut","Casc","Espasa","Casc","Espasa","Espasa","Espasa","Escut","Casc","Espasa","Armadura","Casc","Espasa","Espasa","Llança","Espasa","Espasa","Casc","Casc","Escut","Casc","Casc","Armadura","Llança","Escut","Armadura","Espasa","Armadura","Escut","Casc","Espasa","Casc","Escut","Escut","Espasa","Armadura","Armadura","Llança","Llança","Armadura","Casc","Casc","Espasa","Llança","Espasa","Armadura","Espasa","Espasa","Llança","Escut","Casc","Casc","Llança","Casc","Llança","Escut","Espasa","Escut","Espasa","Escut","Llança","Llança","Llança","Llança","Casc","Espasa","Armadura","Casc","Escut","Llança","Llança","Armadura","Espasa","Escut","Casc","Casc","Casc","Espasa","Espasa","Armadura","Casc","Escut","Espasa","Casc","Armadura","Armadura","Espasa","Casc","Escut","Espasa","Espasa","Escut","Escut","Escut","Escut"
};
(casc,Armadura,Espasa,Llança,escut) = ArmesTenim(casc,Armadura,Espasa,Llança,escut,armes);
lluitadors=QuantsSoldatsTenim(Armadura,Llança,Espasa,casc,escut);
Solució(lluitadors);

int [] QuantsSoldatsTenim(int Armadura , int Llança , int Espasa , int casc , int escut){
    var ok = false;
    while (!ok){
        if (Llança >= 1 && casc >=1 && escut >=1 && Armadura>=1){
            lluitadors [0] ++;
            Llança--;
            casc--;
            escut--;
            Armadura--;
        } else if (Espasa >= 1 && casc >=1 && escut >=1){
                lluitadors [1] ++;
                casc--;
                Espasa--;
                escut--;
            } else if (Llança >= 1){
                    lluitadors [2] ++;
                    Llança--;
                } else {
                    ok = true;
                }
    }
    return lluitadors;
}

(int,int,int,int,int) ArmesTenim (int casc , int Armadura , int Espasa , int Llança , int escut , string[] armes ){
    for (int i=0 ; i<armes.Length ; i++){
        switch (armes [i]){
            case "Casc":
            casc++;
            break;

            case "Llança":
            Llança++;
            break;

            case "Espasa":
            Espasa++;
            break;

            case "Escut":
            escut++;
            break;

            case "Armadura":
            Armadura++;
            break;
        }
    }
    return (casc,Armadura,Espasa,Llança,escut);
}

void Solució(int [] lluitadors){
    Console.WriteLine ($"Podem enviar a lluitar el drac {lluitadors[0]} Cavallers, {lluitadors[1]} Soldats i {lluitadors[2]} Pagesos");
}