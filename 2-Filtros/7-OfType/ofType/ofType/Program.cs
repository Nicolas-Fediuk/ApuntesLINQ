using ofType;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true, Ingreso = new DateTime(2023,12,6)}
};

var lista = new List<Object>() { "Nicolas", 1, 2, "fediuk", true };

//OfType permite estraer de un conjunto de datos, en este caso de tipo string
var strings = lista.OfType<String>();

foreach(var s in strings)
{
    Console.WriteLine(s);
}

// Extrae los datos solo del tipo entero
var enteros = lista.OfType<int>();

foreach(int i in enteros)
{
    Console.WriteLine(i);
}

//Extrae los datos solo del tipo bool 
var booleanos = lista.OfType<bool>();

foreach(bool i in booleanos) {
    Console.WriteLine(i); 
}
