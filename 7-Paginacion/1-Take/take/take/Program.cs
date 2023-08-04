var numeros = Enumerable.Range(1, 100);

//me trae los primeros 10 numeros
var primeros10Numeros = numeros.Take(10).ToList();

//me trae los ultimoss 10 numeros 
var ultimos10Numeros = numeros.TakeLast(10).ToList();