int[] A = { 1, 2, 3 };

int[] B = { 4, 5, 6 };

//zip conbina elementos respectivos de dos colecciones

var combinados = A.Zip(B);

// (1,4) (2,5) (3,6)
foreach(var combi in combinados)
{
    Console.WriteLine($"({combi.First}, {combi.Second})");
}

//Multiplica los elementos respectivos de dos colecciones unidas
var resulta = A.Zip(B, (A, B) => A * B);
