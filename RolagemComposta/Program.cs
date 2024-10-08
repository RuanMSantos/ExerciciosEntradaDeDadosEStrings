Console.WriteLine("--- Rolagem de Dados ---");

Console.Write("\nDigite a rolagem desejada...: ");
string resposta = Console.ReadLine()!.Trim().ToLower();

Console.WriteLine($"\n{Dado(resposta)} dado(s) de {Face(resposta)} face(s) mais {Bonus(resposta)}");

string Dado(string dado) => dado.Substring(0, resposta.IndexOf("d"));
string Face(string face) => face.Substring(resposta.IndexOf("d") + 1, resposta.IndexOf("+") - resposta.IndexOf("d") - 1);
string Bonus(string bonus) => bonus.Substring(resposta.IndexOf("+") + 1);