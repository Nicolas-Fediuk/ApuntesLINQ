int[] numeros = Enumerable.Range(1, 20).ToArray();

//var numerosImpares = numeros.Where(n => n % 2 != 0);

//foreach(var num in numerosImpares)
//{
//    Console.WriteLine(num + " Es impar"); 
//}

//sintaxis de metodo
var imparMayor10 = numeros.Where(n => n % 2 != 0 && n > 10);

foreach (var num in imparMayor10)
{
    Console.WriteLine($"Impar mayor a 10: {num}");
}

//sintaxis de query
var imparesMyor10x = from n in numeros
                     where n % 2 != 0 && n > 10
                     select n;


foreach (var num in imparesMyor10x)
{
    Console.WriteLine($"Impar mayor a 10: {num}");
}
