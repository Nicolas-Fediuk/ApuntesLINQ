using groupJoin;

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
    new Empresa{id = 3, nombre= "YPF"},
    new Empresa{id = 4, nombre= "Mercado libre"}
};

//funciona como un Left Join

var personasYempresas = Empresas.GroupJoin(Personas, e => e.id, p => p.idEmpresa, (empresa, personas) => new { Empresa = empresa, Persona = personas });

foreach(var item in personasYempresas)
{
    Console.WriteLine($"Las siguientes personas trabajan en la siguiente empresa {item.Empresa.nombre}");

    foreach(var persona in item.Persona)
    {
        Console.WriteLine(persona.nombre);
    }
}

//sintaxis de query

var personasYempresas_2 = from e in Empresas
                          join
                          p in Personas on
                          e.id equals p.idEmpresa into p
                          select new
                          {
                              empresa = e,
                              persona = p
                          };

foreach (var item in personasYempresas_2)
{
    Console.WriteLine($"Las siguientes personas trabajan en la siguiente empresa {item.empresa.nombre}");

    foreach (var persona in item.persona)
    {
        Console.WriteLine(persona.nombre);
    }
}