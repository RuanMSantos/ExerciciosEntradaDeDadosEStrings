Console.Clear();
 
Console.WriteLine("----- Gritador -----");
 
Console.Write("\nDigite algo: ");
string gritando = Console.ReadLine()!.ToUpper();
 
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\n{gritando}");
Console.ResetColor();