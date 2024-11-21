var n1s= "0";
var n2s= "0";
var n3s= "0";
var n4s= "0";
var n5s= "0";
var n1= 0;
var n2= 0;
var n3= 0;
var n4= 0;
var n5= 0;

var ok1=false;
var ok2=false;
var ok3=false;
var ok4=false;
var ok5=false;

var mesgran = 0;

while (ok1==false){
Console.WriteLine("Escriu un numero: ");
n1s = Console.ReadLine();
ok1 = int.TryParse(n1s , out n1);
if (ok1==false){
    Console.WriteLine("Aixó no és un numero!");
}
}
while (ok2==false){
Console.WriteLine("Escriu un numero: ");
n2s = Console.ReadLine();
ok2 = int.TryParse(n2s , out n2);
if (ok2==false){
    Console.WriteLine("Aixó no és un numero!");
}
}
while(ok3==false){
Console.WriteLine("Escriu un numero: ");
n3s = Console.ReadLine();
ok3 = int.TryParse(n3s , out n3);
if (ok3==false){
    Console.WriteLine("Aixó no és un numero!");
}
}
while(ok4==false){
Console.WriteLine("Escriu un numero: ");
n4s = Console.ReadLine();
ok4 = int.TryParse(n4s , out n4);
if (ok4==false){
    Console.WriteLine("Aixó no és un numero!");
}
}
while(ok5==false){
Console.WriteLine("Escriu un numero: ");
n5s = Console.ReadLine();
ok5 = int.TryParse(n5s , out n5);
if (ok5==false){
    Console.WriteLine("Aixó no és un numero!");
}
}
if(n1>n2){
    mesgran=n1;
}else {
    mesgran=n2;
}
if (mesgran<n3){
    mesgran=n3;
}else{
    if(mesgran<n4){
        mesgran=n4;
    }else {
        if(mesgran<n5){
        mesgran=n5;
        }
    }
}
Console.WriteLine($"El numero més gran és {mesgran}.");