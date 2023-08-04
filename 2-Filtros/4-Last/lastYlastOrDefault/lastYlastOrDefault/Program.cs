using lastYlastOrDefault;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)}
};

//Me trae la ultima persona de la lista con el filtro de que esta soltero
var ultimaPersona = Personas.Last(p => p.Soltero == false).Nombre;

Console.WriteLine($"La ultima persona es: {ultimaPersona}");

//LastOrDefault me permite valores nulos
var num = new List<int>();

var numList = num.LastOrDefault();

Console.WriteLine($"El ultimo numero es: {numList}");