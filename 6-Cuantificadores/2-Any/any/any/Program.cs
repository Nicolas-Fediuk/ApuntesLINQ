using any;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Telefonos = {"123-234","456-678"},Ingreso = new DateTime(2023,03,1)} ,
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false,Telefonos = {"574-567","146-432"}, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Telefonos = { "125-247", "792-469" },Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true,Telefonos = {"035-256","403-356"}, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true,Ingreso = new DateTime(2023,12,6)}
};

//si existe algun elemento con la caracteristica indicada
//vuelve false porque no hay ningun menor 
var existeMenor = Personas.Any(p => p.Edad < 18);
Console.WriteLine(existeMenor);

//Si existe al menos una persona mayor a 22
var existeMayor = Personas.Any(p => p.Edad > 22);
Console.WriteLine(existeMayor);