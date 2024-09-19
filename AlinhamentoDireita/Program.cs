Console.Clear();
 
Console.WriteLine("--- Alinhamento à direita ---");
 
Console.Write("\nDigite a primeira palavra...: ");
string palavra1 = Console.ReadLine()!.Trim();
 
Console.Write("Digite a primeira palavra...: ");
string palavra2 = Console.ReadLine()!.Trim();
 
Console.Write("Digite a primeira palavra...: ");
string palavra3 = Console.ReadLine()!.Trim();
 
Console.WriteLine($"\n{palavra1.PadLeft(20, ' ')}");
Console.WriteLine($"{palavra2.PadLeft(20, ' ')}");
Console.WriteLine($"{palavra3.PadLeft(20, ' ')}");