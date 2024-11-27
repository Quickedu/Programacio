
string[] armes = {
"Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança", "Escut", "Escut", "Casc", "Armadura", "Escut", "Llança", "Espasa", "Escut", "Llança", "Escut", "Espasa", "Casc", "Casc", "Escut", "Espasa", "Llança", "Llança", "Espasa", "Armadura", "Escut", "Escut", "Armadura", "Armadura", "Llança", "Armadura", "Espasa", "Escut", "Casc", "Escut", "Espasa", "Armadura", "Armadura", "Casc", "Casc", "Llança", "Casc", "Escut", "Escut", "Llança", "Llança", "Casc", "Espasa", "Armadura", "Casc", "Armadura", "Espasa", "Llança", "Casc", "Llança", "Llança", "Espasa", "Casc", "Espasa", "Casc", "Armadura", "Casc", "Casc", "Armadura", "Llança", "Escut", "Escut", "Armadura", "Llança", "Espasa", "Casc", "Llança", "Armadura", "Espasa", "Casc", "Escut", "Armadura", "Llança", "Llança", "Casc", "Casc", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Armadura", "Espasa", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Casc", "Llança", "Armadura", "Casc", "Armadura", "Llança", "Casc", "Escut", "Espasa", "Casc", "Casc", "Llança", "Llança", "Armadura", "Casc", "Llança", "Llança", "Espasa", "Llança", "Armadura", "Casc", "Casc", "Escut", "Casc", "Llança", "Casc", "Escut", "Llança", "Escut", "Espasa", "Escut", "Llança", "Armadura", "Casc", "Escut", "Espasa", "Llança", "Llança", "Casc", "Escut", "Casc", "Espasa", "Escut", "Escut", "Llança", "Llança", "Llança", "Llança", "Casc", "Escut", "Armadura", "Llança", "Casc", "Espasa", "Espasa",
};
int[] tropes = {0,0,0};
int [] armesnostres = {0,0,0,0,0};

armesnostres = contararmes(armes , armesnostres);
tropes = enviartropes(armesnostres,tropes);
Console.WriteLine($"Podem enviar {tropes[0]} cavallers, {tropes[1]} soldats i {tropes [2]} pagesos.");



int [] contararmes (string[] armes , int [] armesnostres){
    for (int i=0; i<armes.Length ; i++)
        switch (armes [i]){
            case "Escut":
            armesnostres [0]++;
            break;
            case "Llança":
            armesnostres [1]++;
            break;
            case "Espasa":
            armesnostres [2]++;
            break;
            case "Casc":
            armesnostres [3]++;
            break;
            case "Armadura":
            armesnostres [4]++;
            break;
        }
    return armesnostres;
}

int [] enviartropes (int [] armesnostres , int [] tropes){
    while (true){
        if (armesnostres [3]>0 && armesnostres [0]>0 && armesnostres [4]>0 && armesnostres [1]>0){
            tropes [0] ++;
            armesnostres [0]--;
            armesnostres [1]--;
            armesnostres [3]--;
            armesnostres [4]--;
        } else if (armesnostres [3]>0 && armesnostres [0]>0 && armesnostres [2]>0){
            armesnostres [0]--;
            armesnostres [2]--;
            armesnostres [3]--;
            tropes [1] ++;
            } else if (armesnostres [1]>0){
            armesnostres [1]--;
                tropes [2] ++;
                } else {
                    break;
                }
    }
    return tropes;
}