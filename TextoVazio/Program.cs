Console.Clear();
 
Console.WriteLine("--- Texto Vazio ---");
 
Console.Write("\nDigite um texto qualquer: ");
string resposta = Console.ReadLine()!;
 
Console.WriteLine(string.IsNullOrEmpty(resposta.Trim()));