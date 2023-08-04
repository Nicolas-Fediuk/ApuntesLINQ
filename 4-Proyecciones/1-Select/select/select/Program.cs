using select;
using System;
using System.Xml;

var Personas = new List<Persona>()
{
    new Persona{Nombre = "Nicolas", Edad = 23 , Soltero = true, Ingreso = new DateTime(2023,03,1)},
    new Persona{Nombre = "Pablo", Edad = 43 , Soltero = false, Ingreso = new DateTime(2023,06,12)},
    new Persona{Nombre = "Ana", Edad = 32 , Soltero = false, Ingreso = new DateTime(2023,06,1)},
    new Persona{Nombre = "Dario", Edad = 53 , Soltero = true, Ingreso = new DateTime(2023,12,12)},
    new Persona{Nombre = "Emiliano", Edad = 43 , Soltero = true, Ingreso = new DateTime(2023,12,6)}
};

//Sirve de consulta, me trae todos los nombres
var nombres = Personas.Select(x => x.Nombre).ToList();

//para consultar mas de una cosa
var nombreApellidos = Personas.Select(x => new {Nombre = x.Nombre, Edad = x.Edad});

foreach (var nombre in nombreApellidos)
{
    Console.WriteLine(nombre);
}


//tambien sirve para pasar datos a una entidad
List<PersonaDTO> dto = new List<PersonaDTO>();

dto.AddRange(Personas.Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad }));

foreach (var dt in dto)
{
    Console.WriteLine($"Nombre: {dt.Nombre}, Edad: {dt.Edad}");
}


//Tambien se pueden hacer operaciones
var numeros = Enumerable.Range(1, 10).ToList();

var numerosDuplicados = numeros.Select(x => x * 2).ToList();


//tambien puedo tener el indice de los registros
var personasIndice = Personas.Select((p, indice) => new {Persona = p, Indice = indice }).ToList();  

foreach(var p in personasIndice)
{
    Console.WriteLine($"({p.Indice})- {p.Persona.Nombre}");
}
















