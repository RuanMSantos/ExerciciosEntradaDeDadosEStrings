Console.Clear();
 
string frase;
 
Console.WriteLine("---- Cebolinha's converter ----");
 
Console.Write("\nDigite uma frase: ");
frase = Console.ReadLine()!;
 
Console.WriteLine("\nO Cebolinha diria...\n");
 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(frase
.Replace("r", "l")
.Replace("R", "L"));
Console.ResetColor();
 