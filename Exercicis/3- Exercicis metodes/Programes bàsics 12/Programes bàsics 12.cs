string [] ovelles = {"blanca","negra","blanca","blanca","negra","blanca","negra","negra"};
var negre = 0;
var blanca = 0;
var ambdos = 0;
var i = 0;
var j = (ovelles.Length)-1;
var repeticio = (ovelles.Length)/2;
var contrari = repeticio-1;

if (repeticio%2!=0){
    Console.WriteLine("Aquesta llista no està bé!");
    return;
}

for (i=repeticio ; i<ovelles.Length ; i++){
    if (ovelles[i]==ovelles[contrari]){
        if (ovelles [i]=="negra"){
            negre ++;
        }else{
            blanca ++;
        }
    } else {
        ambdos ++;
    }
}

// for (i=0 ; i<repeticio ; i++){
//     if (ovelladavant(ovelles,i)==ovelladarrera(ovelles,j)){
//         if (ovelladarrera(ovelles,j)=="negra"){
//             negre ++;
//         }else{
//             blanca ++;
//         }
//     } else {
//         ambdos ++;
//     }
//     j--;
// }
// Console.WriteLine($"Hi han {negre} ovelles negres, {blanca} ovelles blanques i {ambdos} ovelles blanques i negres");

// string ovelladavant (string [] ovelles , int i){
//     var colordavant = "";
//     colordavant = ovelles [i];
//     return colordavant;
// }

// string ovelladarrera (string [] ovelles , int j){
//     var colordarrera = "";
//     colordarrera = ovelles[j];
//     return colordarrera;
// }