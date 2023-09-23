using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjetoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Console.WriteLine("Primeira Aula C# Console");

            //string Nome = "Ronaldo";

            //Console.WriteLine("Digite um nome com mais de 4 letras: ");
            //Nome = Console.ReadLine();

            //if (Nome == null || Nome.Equals(""))
            //{
            //    Console.WriteLine("ALERTA - Entre com um nome válido!");
            //    Console.WriteLine("Tente outra vez");
            //}
            //else if (Nome.Equals("Adriano"))
            //{
            //    Console.WriteLine($"Nome: {Nome}");
            //}

            //else
            //{
            //    if (Nome.Length <= 4)
            //        Console.WriteLine("O nome precisa ter mais de 4 letras!");
            //    else
            //        Console.WriteLine("\n\n O nome digitado é: " + Nome);
            //}

            //Console.WriteLine($"\n\n O nome \\ digitado é: {Nome}"); // - (\\) é para acrescentar uma / no texto

            //// Control K + D = formata o código

            //// A condição if ou else não precisa de chave({}) se for SÓ uma linha de comando a ser processado.

            //Console.WriteLine("\n Entre com o salário do cliente: ");
            //double salario = Convert.ToDouble(Console.ReadLine());            //ReadLine - lê string
            //Console.WriteLine($"\n O salário digitado foi {salario}");

            //Console.WriteLine("\n Digite sua renda mensal: ");
            //NumberStyles style = NumberStyles.AllowCurrencySymbol;
            //string valor = Console.ReadLine();
            ////decimal renda = Decimal.Parse(valor, style);              //.Parse - converte o ReadLine (que recebeu uma string (texto))
            //double renda = double.Parse(valor);
            //decimal rendaDecimal = decimal.Parse(valor);    

            //Console.WriteLine("\n O valor informado é {0}", valor);
            //Console.WriteLine(String.Format("{000000.00}", rendaDecimal));
            //Console.WriteLine("\n A renda informada é " + renda.ToString("F",CultureInfo.InvariantCulture));


            //Console.ReadKey();            // Para o código no final




            //double numDecimal = 0;
            //try
            //{
            //    numDecimal = Convert.ToDouble(Console.ReadLine());
            //    if (numDecimal >= 20)
            //        Console.Write("Número: " + numDecimal.ToString("C2"));
            //    else
            //        Console.WriteLine("Menor que 20");
            //}
            //catch(Exception ex)
            //{
            //    Console.Write(ex.Message + "Erro!!!");
            //} 






            // Vetor
            //int[] vetor = new int[20];
            //for (int x = 0; x < vetor.Length; x++)
            //{
            //    vetor[x] = x + 1;
            //    Console.WriteLine("\n O valor do indice é: " + x);
            //}






            // Matriz
            //int[,] matriz = new int[5, 2];
            //for (int x = 0; x < matriz.GetLength(0); x++)
            //{
            //    for(int y = 0; y < matriz.GetLength(1); y++)
            //    {
            //        matriz.SetValue(x + y + 1, x, y);
            //        Console.WriteLine($"{x} x {y} = {matriz[x,y]}");
            //    }
            //}








            Pessoa qualquer = new Pessoa();
            qualquer.Name = "Tomas";
            qualquer.CPF = "123";
            string mensagem  = qualquer.PagarConta("2432341", 5);
            qualquer.PagarConta("234234234234");
            qualquer.codigoBarras = "1111111";
            Console.WriteLine(qualquer.PagarConta());

            Console.WriteLine(mensagem);

            Cliente novo = new Cliente();
            novo.Name = "Alberto";
            Console.WriteLine(novo.Name);
            novo.PagarConta("234234234");

            Console.ReadKey();
        }
        public partial class Pessoa
        {
            // Atributos
            public int Id { get; set; }
            public string Name { get; set; }
            public string CPF { get; set; }
            public decimal valor { get; set; }
            public string codigoBarras { get; set; }


            // métodos
            public void PagarConta(string _codigoBarras)  // método >> void << só recebe, não devolve nada (método sem retorno)
            {
                this.codigoBarras = _codigoBarras;        // this. - referenciar o próprio atributo da classe
                Console.WriteLine($"Pagando conta {this.codigoBarras}");
            }
            public string PagarConta(string _codigoBarras, int validador)  // método >> string << recebe e devolve no (return) uma string 
            {                                                              // método com retorno
                this.codigoBarras = _codigoBarras;        
                return $"Pagando conta {this.codigoBarras} com validador {validador}";  
            }

            public string PagarConta()                      // método não recebe nenhum argumento
            {                                                              
                return $"Pagando conta {this.codigoBarras}";
            }

        }
        class Cliente : Pessoa     // super classe
        {
            public decimal RendaMensal {get; set;}
            // sobrescrita do método
            public new string PagarConta()
            {
                return "nova forma de pagar conta!";
            }

        }
    }
}
