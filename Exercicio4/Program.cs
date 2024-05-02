Console.WriteLine("Digite uma ou mais palavras separadas por espaços:");

string input = Console.ReadLine();

string[] palavras = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


foreach (string palavra in palavras)
{
    Console.WriteLine($"A palavra '{palavra}' tem {palavra.Length} caracteres.");
}

Console.ReadKey();