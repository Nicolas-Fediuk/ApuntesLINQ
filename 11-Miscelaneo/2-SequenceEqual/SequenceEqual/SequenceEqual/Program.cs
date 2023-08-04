string[] A = { "Nicolas", "Fediuk" };

string[] B = { "Nicolas", "Fediuk" };

string[] C = { "NiCoLaS", "FeDiUk" };

string[] D = { "Abel", "Nicolas" };

//sirve para compara los colecciones 

//true porque son iguales
var AB =  A.SequenceEqual(B);

//false porque no son iguales
var AC = A.SequenceEqual(C);

//true porque son iguales, para comparar sin importar la mayuscula 
var ACsinImportarMayuscula = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);

//false porque no son iguales
var AD = A.SequenceEqual(D);




