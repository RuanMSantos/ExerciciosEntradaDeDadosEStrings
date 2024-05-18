Console.Clear();
 
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;
 
Console.Write("Olá ");
 
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"{nome}");
Console.ResetColor();