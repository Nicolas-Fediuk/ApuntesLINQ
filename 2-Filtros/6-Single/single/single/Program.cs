using single;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true, Ingreso = new DateTime(2023,12,6)}
};

// Single me trae un solo registro que cumpla la condicion 
var personaIgual32 = Personas.Single(p => p.Edad == 32);
Console.WriteLine(personaIgual32.Nombre);

//No me permite valores nulos
try
{
    var personasMayores70 = Personas.Single(p => p.Edad > 20);
}
catch (Exception ex)
{
    Console.WriteLine("Error: Se paso del rango de edad");

    //default no me tira error
    var personaDefault = Personas.SingleOrDefault(p =>
    {
        return p.Nombre == "Nombre default mayores a 20 años con mas de un registro";
    });

    Console.WriteLine(personaDefault);
}

try
{
    var personasCon43 = Personas.Single(p => p.Edad == 43);
}
catch(Exception ex)
{
    Console.WriteLine("Error: Hay mas de un registro");
} 