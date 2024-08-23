Console.Clear();
 
Console.WriteLine("---- Primeiro caractere ----");
 
Console.Write("\nDigite um palavra: ");
string palavra = Console.ReadLine()!.Trim().Substring(0, 1);
 
Console.WriteLine($"Primeiro caractere: {palavra}");