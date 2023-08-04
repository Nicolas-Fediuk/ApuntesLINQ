using selectMany;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Telefonos = {"123-234","456-678"},Ingreso = new DateTime(2023,03,1)} ,
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false,Telefonos = {"574-567","146-432"}, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Telefonos = { "125-247", "792-469" },Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true,Telefonos = {"035-256","403-356"}, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true,Ingreso = new DateTime(2023,12,6)}
};

//nos da una coleccion de elementos
var telefono = Personas.SelectMany(p => p.Telefonos).ToList();

//nos da una coleccion de colecciones 
var telefonoSelect = Personas.Select(p => p.Telefonos).ToList();

foreach(var p in telefono)
{
   // Console.WriteLine(p);
}

foreach(var p2 in telefonoSelect)
{
   // Console.WriteLine(p2);
}

//ejemplo 2 con dos coleeciones diferentes
//relaciona los elementos de persona con los de numero

int[] numeros = { 1, 2, 3 };

var personasYnumeros = Personas.SelectMany(p => numeros, (persona, numero) => new
{
    Persona = persona,
    Numero = numero
});

foreach(var pYn in personasYnumeros)
{
    //Console.WriteLine(pYn.Persona.Nombre +" - "+pYn.Numero);
}

//Ejemplo 3: personas y telefonos, Me trae los nombre y los respectivos telefnos de cada persona

var personasYtelefonos = Personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
{
    Persona = persona,
    Telefonos = telefono
});

foreach(var pYt in personasYtelefonos)
{
    //Console.WriteLine($"Persona: {pYt.Persona.Nombre}, Su telefono: {pYt.Telefonos}");
}


//Sintaxis de querys

var Telefonos2 = from p in Personas
                 from t in p.Telefonos
                 select t;

var personasYnuemros2 = from p in Personas
                        from n in numeros
                        select new
                        {
                            Persona = p,
                            Telefonos = n
                        };


