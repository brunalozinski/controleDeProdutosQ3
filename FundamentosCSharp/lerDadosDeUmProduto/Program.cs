using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerDadosDeUmProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler dados de um produto");

            string produto = "";
            int codigo = 0;
            string descricao = "";
            string valor = "";
            int quantidade = 0;
            int ano = 0;
            int mes = 0;
            int dia = 0;

            Console.WriteLine("Digite o nome do produto: ");
            produto = Console.ReadLine();

            Console.WriteLine("\n O nome do produto é: " + produto);

            Console.WriteLine("\n Digite o código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n O código do produto é: " + codigo);

            Console.WriteLine("\n Digite a descrição do produto: ");
            descricao = Console.ReadLine();

            Console.WriteLine("\n A descrição do produto é: " + descricao);

            Console.WriteLine("\nDigite o valor do produto: ");
            valor = Console.ReadLine();

            Console.WriteLine("\n O valor do produto é: " + decimal.Parse(valor));

            Console.WriteLine("\n Digite a quantidade do produto: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n A quantidade do produto é: " + quantidade);

            Console.WriteLine("\n Digite o ano de vencimento do produto: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Digite o mês de vencimento do produto: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Digite o dia de vencimento do produto: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n A validade do produto é: {0}/{1}/{2}", dia, mes, ano);
            Console.ReadKey();

        }
    }
}
