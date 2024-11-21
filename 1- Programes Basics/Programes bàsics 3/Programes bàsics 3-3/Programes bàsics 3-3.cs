Random r = new();
var tirades = 0;
var num = 0;

while (num<=100){
    num = num+r.Next(1,6);
    tirades = tirades+1;
}
Console.WriteLine($"He hagut de tirar el dau {tirades} vegades.");