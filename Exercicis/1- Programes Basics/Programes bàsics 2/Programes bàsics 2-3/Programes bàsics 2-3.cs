//definim variables
var usuari = "0";
var password = "0";
var password2 = "0";
bool userNum = false;
bool passNum = false;

//Iniciem programa
Console.WriteLine("Usuari:");
usuari = Console.ReadLine();
//Despres de definir "usuari", comprovem que sigui aquest correcte.
if (usuari=="administrador" || usuari=="root" || usuari=="usuari" || usuari=="public"){
    userNum=true;       
}
//Si es correcte, filtrem entre administradors i usuaris comuns
if (userNum==true & passNum==false & usuari=="administrador" || usuari=="root"){
                Console.WriteLine($"Benvingut {usuari}!"); 
}
//Si es admin, no es demanara contrasenya
else
{ 
    if (userNum==true){
    passNum=true;
    } 
    //En cas que no sigui administrador, es definira com a "true" la variable del password, per tant s'activara el seguent if.
}
if (userNum==true & passNum==true & usuari=="usuari" || usuari=="public"){
    Console.WriteLine("Escriu la teva contrasenya:");
    password = Console.ReadLine();
    Console.WriteLine($"Contrasenya incorrecte, torna a provar novament:");
    password2 = Console.ReadLine();
    if (password2 == password){
        Console.WriteLine ($"Contrasenya correcte. Benvingut {usuari}");
    }else{
        while(password2!=password){
            Console.WriteLine ("Aquesta contrasenya és incorrecte. Torna a provar d'introduir la contrasenya:");
            Console.WriteLine ("Hint! Try again with your first password");
            password2 = Console.ReadLine();
        }
        Console.WriteLine ($"Contrasenya correcte. Benvingut {usuari}!");
    }
}
if (userNum==false) {
    Console.WriteLine("Usuari incorrecte!");
    }
//Si no s'ha complert la primera condició pels usuaris, la variable "userNum" sera falsa.
//Per tant, el programa no deixara fer "login" a la persona.
