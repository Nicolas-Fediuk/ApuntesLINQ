
int[] numeros = Enumerable.Range(1,10).ToArray();

//sintaxis de metodos
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

//Otra forma de hacerlo
var numerosPares2 = numeros.Where(n => {

    Console.WriteLine($"Evaluando si {n} es par");
    return n % 2 == 0;

});
//Tambien se puede usar ToList o ToArray

//sintaxis de querys, casi no se usa

//var numerosPares2 = (from n in numeros
//                     where n % 2 == 0
//                     select n).ToList();


foreach (var numero in numerosPares2)
{
    Console.WriteLine($"Si, {numero} es par");
}
