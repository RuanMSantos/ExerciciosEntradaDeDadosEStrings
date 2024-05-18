Console.Clear();
 
string nome, sobrenome;
 
Console.WriteLine("----- Nome e Sobrenome -----");
 
Console.Write("\nDigite seu primeiro nome: ");
nome = Console.ReadLine()!;
 
Console.Write("\nDigite seu sobrenome: ");
sobrenome = Console.ReadLine()!;
 
Console.WriteLine($"\nNome completo: {nome} {sobrenome}");
 
Console.WriteLine($"\nNome de catálogo: {sobrenome.ToUpper()}, {nome}");