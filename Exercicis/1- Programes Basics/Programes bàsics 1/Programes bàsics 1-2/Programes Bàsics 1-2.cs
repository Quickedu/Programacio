decimal pesieuro = 166.386m;
Console.WriteLine("Indica el valor en euros:");
var euroString = Console.ReadLine();
int euro = Convert.ToInt32(euroString);
decimal resultat = pesieuro*euro;
decimal resultatok = Math.Round (resultat);
Console.WriteLine("Aixó son: " + resultatok + " pesetes");