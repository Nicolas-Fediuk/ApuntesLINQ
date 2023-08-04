var numeros = Enumerable.Range(1, 100);

//me saltea los primeros 10 y me trae los 10 despues de los salteados 
var segundoLoteDe10 = numeros.Skip(10).Take(10);

//me trae los antes ultimos 10 numeros
var anteultimoLote10 = numeros.SkipLast(10).TakeLast(10);

