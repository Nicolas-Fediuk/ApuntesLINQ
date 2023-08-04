using firts;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)}
};

//Me devuelve el nombre de la primera persona de la lista, con el filtro de que este soltera
var primeraPersona = Personas.First(n => n.Soltero == false).Nombre;

Console.WriteLine($"La primera persona es: {primeraPersona}");

//FirstOrDefault me permite valores nulos 
var ejemplo = new List<string>();

var e = ejemplo.FirstOrDefault();

Console.WriteLine($"Primer numero: {e}");
