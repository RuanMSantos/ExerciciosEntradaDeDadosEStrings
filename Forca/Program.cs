Console.WriteLine("--- Forca ---\n");

Console.Write("Qual a palavra secreta? ");
string palavra = Console.ReadLine()!;

Console.Write("Qual a palavra secreta? ");
string letra = Console.ReadLine()!.Trim().ToLower().Substring(0, 1);

bool verificador = palavra.ToLower().Contains(letra);

Console.WriteLine($"\nA letra \"{letra}\" existe na palavra secreta => {verificador}");