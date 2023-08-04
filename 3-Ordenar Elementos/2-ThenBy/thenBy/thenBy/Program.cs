using thenBy;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true, Ingreso = new DateTime(2023,12,6)}
};

//ThenBy nos pormite ordenar por otra propiedad mas 
//en este caso ordena por edad y nombre 
var per = Personas.OrderBy(p => p.Edad).ThenBy(p => p.Nombre);

//tambien existe ThenByDescending

foreach(var p in per)
{
    Console.WriteLine($"La personas {p.Nombre}, tiene {p.Edad} años");
}
