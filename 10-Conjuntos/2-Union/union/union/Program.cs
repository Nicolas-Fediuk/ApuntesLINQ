using union;

var PersonasA = new List<Persona>()
{
    new Persona{nombre = "Nicolas", idEmpresa = 1},
    new Persona{nombre = "Pablo", idEmpresa = 1},
    new Persona{nombre = "Andrea", idEmpresa = 2},
    new Persona{nombre = "Juan", idEmpresa = 3},
    new Persona{nombre = "Pepe", idEmpresa = 3},
    new Persona{nombre = "Cristobal"},
    new Persona{nombre = "Pablo" }
};

var PersonasB = new List<Persona>()
{
    new Persona{nombre = "Nicolas", idEmpresa = 3},
    new Persona{nombre = "Camelio", idEmpresa = 1},
};

int[] numerosA = { 1, 2, 3, 4, 5 };

int[] numerosB = { 6, 7, 2, 1, };

//union me permite unir dos colecciones, quitando lo repetido 
var unionNumeros = numerosA.Union(numerosB);

//me trar la union de los nombre de los dos objetos de personas sin repetir el nombre 
var unionNombres = PersonasA.UnionBy(PersonasB, p => p.nombre);

foreach(var n in unionNumeros)
{
    Console.WriteLine(n);
}

