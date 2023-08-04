using intersect;

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

int[] num1 = { 1, 4, 6 };

int[] num2 = { 1, 34, 56 };

//los numeros que tiene en comun num1 con num2
var numerosEnComun = num1.Intersect(num2);

foreach (var n in numerosEnComun)
{
    Console.WriteLine(n);
}

//Nombre de personas en comun
var nombresB = PersonasB.Select(p => p.nombre);

var nombreEnComun = PersonasA.IntersectBy(nombresB, p => p.nombre);

foreach(var p in nombreEnComun)
{
    Console.WriteLine(p.nombre);
}


