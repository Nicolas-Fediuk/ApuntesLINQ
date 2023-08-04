using distinct;
using System.Data.Common;

var Personas = new List<Persona>()
{
    new Persona{nombre = "Nicolas", idEmpresa = 1},
    new Persona{nombre = "Pablo", idEmpresa = 1},
    new Persona{nombre = "Andrea", idEmpresa = 2},
    new Persona{nombre = "Juan", idEmpresa = 3},
    new Persona{nombre = "Pepe", idEmpresa = 3},
    new Persona{nombre = "Cristobal"},
    new Persona{nombre = "Pablo" }
};

var Empresas = new List<Empresa>()
{
    new Empresa{id = 1, nombre= "Google"},
    new Empresa{id = 2, nombre= "Amazon"},
    new Empresa{id = 3, nombre= "YPF"},
    new Empresa{id = 4, nombre= "Mercado libre"}
};

int[] numeros = { 1, 2, 3, 1, 1, 4, 5 };

var numerosSinRepetir = numeros.Distinct();

//me trae las personas con los nombres sin repetir 
var personasSinRepetirNombre = Personas.DistinctBy(p => p.nombre);

//Sintaxis de query

var numerosSinRepetir_2 = from n in numeros.Distinct()
                          select n;

var personasSinRepetirNombre_2 = 



