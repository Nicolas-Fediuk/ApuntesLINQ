using except;

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

//Todo lo que este en num1 que no este en num2 
var numeroEnAnoEstenB = num1.Except(num2); //4,6

//Todas las personas que estan en A que no esten en B
var personasEnB = PersonasB.Select(x => x.nombre);
var personasEnAqueNoEnB = PersonasA.ExceptBy(personasEnB, p => p.nombre);

foreach(var n in numeroEnAnoEstenB)
{
    Console.WriteLine(n);
}