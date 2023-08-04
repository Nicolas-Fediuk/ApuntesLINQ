using element;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)}
};

// podes seleccionar un elemento de la lista en una posicion determinada
var EleccionIndice = Personas.ElementAt(1).Nombre;

Console.WriteLine($"Nombre en la posicion 1: {EleccionIndice}");

//Admite valores nulos en la lista
var eE = Personas.ElementAtOrDefault(10);

Console.WriteLine($"{eE}");