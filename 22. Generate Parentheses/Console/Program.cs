// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Digite a quantidade de parêntesis:");
var n = Console.ReadLine();
if (Convert.ToInt32(n) > 0)
{
    Console.WriteLine($"Iniciando processamento com n={n}");
    var result = new Domain.Solution().GenerateParenthesis(Convert.ToInt32(n));
    Console.WriteLine($"['{String.Join("', '", result)}']");
}
else
{
    Console.WriteLine("Saindo...");
}


