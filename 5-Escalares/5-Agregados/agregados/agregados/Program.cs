var numeros = Enumerable.Range(1, 5);


var resultado = numeros.Aggregate((a, b) => a * b); 

// es 1*2*3*4*5 = 120
Console.WriteLine(resultado);

//Resultado con valor inicial = 1200
var resultadoConValorInicial = numeros.Aggregate(10,(a, b) => a * b);
Console.WriteLine(resultadoConValorInicial);