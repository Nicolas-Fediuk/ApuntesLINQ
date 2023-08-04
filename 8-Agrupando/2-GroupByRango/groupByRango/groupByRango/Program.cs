using groupByRango;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Telefonos = {"123-234","456-678"},Ingreso = new DateTime(2023,03,1)} ,
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false,Telefonos = {"574-567","146-432"}, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Telefonos = { "125-247", "792-469" },Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true,Telefonos = {"035-256","403-356"}, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true,Ingreso = new DateTime(2023,12,6)}
};

var personasEdadRango = Personas.GroupBy(p => p.Edad / 5);

foreach (var edad in personasEdadRango)
{
    Console.WriteLine($"Grupos de personas en el rango de edad {edad.Key * 5} - {edad.Key * 5 + 5 -1}");

    foreach(var e in edad)
    {
        Console.WriteLine($"Persona : {e.Nombre} Edad: {e.Edad}");
    }
}