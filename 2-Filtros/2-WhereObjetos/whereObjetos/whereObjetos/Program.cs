using whereObjetos;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)}
};

var person = Personas.Where(p => p.Edad > 23);

Console.WriteLine($"Personas con edad Mayores a 23");

foreach (var p in person)
{
    Console.WriteLine(p.Nombre);
}

var solteros = Personas.Where(p => p.Soltero && p.Edad > 23);

Console.WriteLine($"Personas solteras mayores a 23");

foreach(var s in solteros)
{
    Console.WriteLine(s.Nombre);
}

Console.WriteLine("Personas que entraron despues de marzo");

var ingreso = Personas.Where(i => i.Ingreso > DateTime.Now);

foreach(var i in ingreso)
{
    Console.WriteLine(i.Nombre);
}
