//se utiliza para saber si puedo hacer un conteo o no

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var conteo = 0;

var contarSinEnumerar = numeros.TryGetNonEnumeratedCount(out conteo);

Console.WriteLine(conteo);
