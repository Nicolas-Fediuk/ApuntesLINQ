using join;

var Personas = new List<Persona>()
{
    new Persona{nombre = "Nicolas", idEmpresa = 1},
    new Persona{nombre = "Pablo", idEmpresa = 1},
    new Persona{nombre = "Andrea", idEmpresa = 2},
    new Persona{nombre = "Juan", idEmpresa = 3},
    new Persona{nombre = "Pepe", idEmpresa = 3},
    new Persona{nombre = "Cristobal"}
};

var Empresas = new List<Empresa>()
{
    new Empresa{id = 1, nombre= "Google"},
    new Empresa{id = 2, nombre= "Amazon"},
    new Empresa{id = 3, nombre= "YPF"}
};

//funciona como un join

var personasYempresa = Personas.Join(Empresas, p => p.idEmpresa, e => e.id, (persona, empresa) => new
{
    Persona = persona,
    Empresa = empresa
});

foreach(var item in personasYempresa)
{
    Console.WriteLine($"La persona {item.Persona.nombre} trabaja en {item.Empresa.nombre}");
}

//Sintaxis de query

var personasYempresa_2 =  from p in Personas
                          join e in Empresas
                          on p.idEmpresa equals e.id
                          select new{
                            persona = p,
                            empresa = e
                          };

foreach (var item in personasYempresa_2)
{
    Console.WriteLine($"La persona {item.persona.nombre} trabaja en {item.empresa.nombre}");
}