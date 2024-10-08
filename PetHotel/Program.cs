Console.WriteLine("Bem vindo ao Pet Hotel \"Nem um pio\"\n");

Console.Write("Espécie: ");
string especie = Console.ReadLine()!;

Console.Write("Raça: ");
string raca = Console.ReadLine()!;

Console.Write("Nome: ");
string nome = Console.ReadLine()!;

Console.Write("Idade: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/cor: ");
string cor = Console.ReadLine()!;

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Pet Hotel \"Nem um pio\"");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");

Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.WriteLine("+=========================================================+");
Console.Write("| Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(nome.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(cor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.WriteLine("+=========================================================+");
Console.ResetColor();