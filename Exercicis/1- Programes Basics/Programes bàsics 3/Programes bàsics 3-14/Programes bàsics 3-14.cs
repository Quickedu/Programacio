var num = 0;
var i = 0;
var j = 0;

Console.WriteLine("Escriu un numero");
num = int.Parse(Console.ReadLine());
for (i=0 ; i<num ; i++){
    for (j=0 ; j<num ; j++){
        if (i==0 || i==(num-1)){
            Console.Write("* ");
        } else if (j==0 || j==(num-1)){
            Console.Write("* ");
        }else if (j>0 && j<(num-1)){
            Console.Write("  ");
        }
    }
    Console.WriteLine("");
}