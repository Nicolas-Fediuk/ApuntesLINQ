using sumaMaxMin;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Telefonos = {"123-234","456-678"},Ingreso = new DateTime(2023,03,1)} ,
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false,Telefonos = {"574-567","146-432"}, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Telefonos = { "125-247", "792-469" },Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true,Telefonos = {"035-256","403-356"}, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true,Ingreso = new DateTime(2023,12,6)}
};

var numeros = Enumerable.Range(1, 5);

//suma los numeros
Console.WriteLine($"Suma de los numeros: {numeros.Sum()}");

//Sumos las edades de persona
Console.WriteLine($"Suma de las edades: {Personas.Sum(p => p.Edad)}");

// edad maxima de las personas
Console.WriteLine($"Edad Maxima de las personas: {Personas.Max(p => p.Edad)}");

// edad minima de las personas
Console.WriteLine($"Edad Minima de las personas: {Personas.Min(p => p.Edad)}");

