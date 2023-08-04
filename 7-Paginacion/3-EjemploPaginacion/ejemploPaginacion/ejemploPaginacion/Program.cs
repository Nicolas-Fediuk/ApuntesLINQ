// paginar numeros de 10 en 10
var numeros = Enumerable.Range(1, 100);

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Pagina: {i}");
    var paginado = numeros.Paginar(i, 10);
    foreach(var n in paginado)
    {
        Console.WriteLine(n);
    }
}

public static class IEnumerableExtensions
{
    public static IEnumerable<T> Paginar<T> (this IEnumerable<T> coleccion, int pagina, int tamañoLote)
    {
        return coleccion.Skip((pagina - 1) * tamañoLote).Take(tamañoLote);
    }
}
