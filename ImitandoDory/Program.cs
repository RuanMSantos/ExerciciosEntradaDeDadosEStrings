Console.WriteLine("--- Procurando Dory ---");

Console.Write("\nDigite uma palavra: ");
string palavra = Console.ReadLine()!;

string conversor = palavra
.Replace("a", "aaa")
.Replace("e", "eee")
.Replace("i", "iii")
.Replace("o", "ooo")
.Replace("u", "uuu")
.Replace("A", "AAA")
.Replace("E", "EEE")
.Replace("I", "III")
.Replace("O", "OOO")
.Replace("U", "UUU");

Console.WriteLine($"\nA Dory diria: {conversor}");
