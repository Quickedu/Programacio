Console.WriteLine("Escriu el primer número:");
var num1s = Console.ReadLine();
Console.WriteLine("Escriu el segon número");
var num2s = Console.ReadLine();
float num1f = float.Parse(num1s);
float num2f = float.Parse(num2s);
int num1 = (int)num1f;
int num2 = (int)num2f;
Console.WriteLine(num1 + "+" + num2 + "=" + (num1+num2));
Console.WriteLine(num1 + "-" + num2 + "=" + (num1-num2));
Console.WriteLine(num1 + "*" + num2 + "=" + (num1*num2));
Console.WriteLine($"{num1} / {num2} = {num1/num2} i la resta és {num1%num2}");