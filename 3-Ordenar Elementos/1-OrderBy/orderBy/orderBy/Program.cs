using orderBy;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true, Ingreso = new DateTime(2023,12,6)}
};

//Ordena las personas por edad, de menor a mayor
var per = Personas.OrderBy(p => p.Edad);

//Ordena las personas por edad, de mayor a menor
//var per = Personas.OrderByDescending(p => p.Edad);

foreach (var p in per){

    Console.WriteLine(p.Nombre);

}

