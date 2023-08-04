int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 1 };

//me trae todos los numeros menores a 5. Igual en adelnate el que vale 5 o mas 
var takeWhile = numeros.TakeWhile(x => x < 5).ToList(); // 1, 2, 3, 4

//Me toma todos los elementos a partir de que se cumpla la condicion 
var skipWhile = numeros.SkipWhile(x => x < 5).ToList(); //  5, 6, 7, 8, 9, 10, 3, 2, 1