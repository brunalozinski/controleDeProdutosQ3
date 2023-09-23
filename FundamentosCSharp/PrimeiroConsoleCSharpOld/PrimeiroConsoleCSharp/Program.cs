// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

Console.WriteLine("Primeira Aula C# Console");

string? Nome = "Ronaldo";

Console.WriteLine("Digite um nome com mais de 4 letras: ");
Nome = Console.ReadLine();

if (Nome == null || Nome.Equals(""))
{ 
    Console.WriteLine("ALERTA - Entre com um nome válido!");
    Console.WriteLine("Tente outra vez");
}
else if (Nome.Equals ("Adriano"))
{
    Console.WriteLine($"Nome: {Nome}");
}

else
{
    if (Nome.Length <= 4)
        Console.WriteLine("O nome precisa ter mais de 4 letras!");
    else
        Console.WriteLine("\n\n O nome digitado é: " + Nome);
}

Console.WriteLine($"\n\n O nome \\ digitado é: { Nome}"); // - (\\) é para acrescentar uma / no texto

// Control K + D = formata o código

// A condição if ou else não precisa de chave({}) se for SÓ uma linha de comando a ser processado.

Console.WriteLine("\n Entre com o salário do cliente: ");
double salario = Convert.ToDouble(Console.ReadLine());            //ReadLine - lê string
Console.WriteLine($"\n O salário digitado foi {salario}");

Console.WriteLine("\n Digite sua renda mensal: ");
NumberStyles style = NumberStyles.AllowCurrencySymbol;
string valor = Console.ReadLine()!;
//decimal renda = Decimal.Parse(valor, style);              //.Parse - converte o ReadLine (que recebeu uma string (texto))
var renda = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);

Console.WriteLine("\n O valor informado é {0}", valor);
Console.WriteLine("\n A renda informada é {0}", renda);
Console.WriteLine("\n O valor informadao é {0}", valor.ToString("C2"));