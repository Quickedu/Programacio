string [,] dades = {
    {"Francés"},
    {"6,6,6,6,6,6,3,3,3,3,4,4,4,4"},
    {"Anglès"},
    {"3,4,3,3,3,5,3,3,3"},
    {"Espanyol"},
    {"1,9,9,9,9,9,9,9,9,9,3,3,3,3,4,4,4,4,1,1"},
};
int i = 0;
string pais = "0";
string paiscandidat = "0";
int mespetit = 100;

for (i=0 ; i<dades.Length; i++){
    pais = nomvaixell(pais);
    if (pais=="Espanyol"){
        paiscandidat=pais;
    }
    if (nopais(dades, i)){
        if (100<=int.Parse(trobardistancia(dades,i))){
            mespetit = calcularvaixellmesaprop(mespetit);
        }
    }
}

Console.WriteLine($"El vaixell {paiscandidat} esta a {calcularvaixellmesaprop(mespetit)} nusos.");

string nomvaixell(string pais){
    if (!nopais(dades,i)){
        pais = dades[i,0];
    }
    return pais;
}

int calcularvaixellmesaprop (int mespetit){
    if (mespetit > int.Parse(trobardistancia(dades,i))){
        mespetit = int.Parse(trobardistancia(dades,i));
    }
    return mespetit;
}

bool nopais (string [,] dades , int i){
    string dadesS = dades [i,0];
    for (int j=0;j<dadesS.Length;j++){
        if (dadesS[j]==','){
            return true;
        }
    }
    return false;
}

int [] numeros (string [,] dades , int i){
    var Snumeros=dades [i,0].Split (",");
    int [] Inumeros = new int [Snumeros.Length];
    for (int ii=0 ; ii<Snumeros.Length ; ii++){
        Inumeros[ii] = int.Parse(Snumeros[ii]);
    }
    return Inumeros;
}

string trobardistancia (string [,] dades , int i){
    string distancia="";
    int [] Idistancia = numeros (dades,i);
    int numero = Idistancia[0];
    var num=0;
    for (var jj=0 ; jj<Idistancia.Length ; jj++){
        if (numero!=Idistancia[jj]){
            if (num == numero){
                distancia = $"{distancia}{numero}";
                num = 0;
            }
            numero = Idistancia[jj];
            num = 0;
        }
        num ++;
    }
    return distancia;
}