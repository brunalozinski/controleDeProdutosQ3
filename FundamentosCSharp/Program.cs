using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //Console.WriteLine("Atividade de retomada");
            //Console.WriteLine("Entre com um nome:");
            //String nome = Console.ReadLine();
            //Console.WriteLine("O nome digitado foi : " + nome);
            //Console.ReadKey();

            //// 2
            //int x;
            //Console.WriteLine("Entre com um número: ");
            //string texto1 = Console.ReadLine();
            //x = Convert.ToInt16(texto1);
            //Console.WriteLine("O número digitado foi! " + x);
            //Console.ReadKey();

            //// 3 
            //Console.WriteLine("Entre com um número: ");
            //String texto2 = Console.ReadLine();
            //x = Convert.ToInt16(texto2);
            //Console.WriteLine("O número digitado foi! " + x);
            //Console.ReadKey();

            //// 4 
            //Console.WriteLine("Entre com um número decimal: ");
            //String texto3 = Console.ReadLine();
            //double numDecimal = Convert.ToDouble(texto3);
            //Console.WriteLine("O número digitado foi! " + numDecimal);
            //Console.ReadKey();            



            //// 5 
            //Console.WriteLine("Entre com um número decimal: ");
            //string texto4 = Console.ReadLine();
            //decimal numDecimal = Decimal.Parse(texto4);
            //Console.WriteLine("O número digitado foi! " + numDecimal);
            //Console.ReadKey();            



            //// 6 
            //Console.WriteLine("Entre com um número decimal: ");
            //string texto5 = Console.ReadLine();
            //decimal numDecimal = Decimal.Parse(texto5);
            //Console.WriteLine("O número digitado foi! " + numDecimal);
            //String textoFromNumero = Convert.ToString("R$" + numDecimal);
            //Console.ReadKey();            



            //// 7 
            //Console.WriteLine("Entre com um número decimal: ");
            //string texto6 = Console.ReadLine();
            //decimal numDecimal = Decimal.Parse(texto6);
            //Console.WriteLine("O número digitado foi! " + numDecimal);
            //if(numDecimal > 5)
            //{
            //    Console.WriteLine("Número maior que 5!!!");
            //}
            //Console.ReadKey();  



            // 8 
            //Console.WriteLine("Entre com um número decimal: ");
            //string texto7 = Console.ReadLine();
            //decimal numDecimal = Decimal.Parse(texto7);
            //Console.WriteLine("O número digitado foi! " + numDecimal);
            //if(numDecimal > 5)
            //{
            //    Console.WriteLine("Número maior que 5!!!");
            //} else
            //{
            //    Console.Beep();
            //}
            //Console.ReadKey();



            // 9 
            //Console.WriteLine("Entre com um número decimal: ");
            //string texto8 = Console.ReadLine();
            //decimal numDecimal = Decimal.Parse(texto8);
            //Console.WriteLine("O número digitado foi! " + numDecimal);
            //if(numDecimal > 5)
            //{
            //    Console.WriteLine("Número maior que 5!!!");
            //} else
            //{
            //    Console.Beep();
            //}
            //Console.ReadKey();   



            //// 10 
            //decimal numDecimal = 1;
            //string texto9;
            //while(numDecimal > 0)
            //{
            //    Console.WriteLine("Entre com um número decimal: ");
            //    texto9 = Console.ReadLine();
            //    numDecimal = Decimal.Parse(texto9);
            //    if(numDecimal>0)
            //        Console.WriteLine("O número digitado foi! " + numDecimal);
            //} 
            //Console.ReadKey();



            //// 11 
            //decimal numDecimal = 1;
            //string texto10;
            //while(numDecimal > 0)
            //{
            //    Console.WriteLine("Entre com um número decimal: ");
            //    texto9 = Console.ReadLine();



            //    try
            //    {
            //        numDecimal = Decimal.Parse(texto10);
            //        if(numDecimal>0)
            //          Console.WriteLine("O número digitado foi! " + numDecimal);
            //    }catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }





            //} 
            //Console.ReadKey();



            //// 12
            //decimal numDecimal = 1;
            //string texto11;
            //while(numDecimal > 0)
            //{
            //    Console.WriteLine("Entre com um número decimal: ");
            //    texto11 = Console.ReadLine();



            //    try
            //    {
            //        Match m = Regex.Match(texto11, "[A-Z][a-z]", RegexOptions.IgnoreCase);
            //        if (!m.Success)
            //        {
            //            numDecimal = Decimal.Parse(texto11);
            //            if (numDecimal > 0)
            //                Console.WriteLine("O número digitado foi! " + numDecimal);
            //        } else
            //        {
            //            Console.WriteLine("Não digite letras, apenas números!");
            //        }
            //    }catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }    
            //} 
            //Console.ReadKey();



            //// 13 
            //int[] vetor = new int[10];
            //for (int x = 0; x < vetor.Length; x++)
            //{
            //    vetor[x] = x + 1;
            //    Console.WriteLine("O valor do índice " + x + " do vetor é " + vetor[x] + " ");
            //}



            //Console.ReadKey();



            //// 14
            //int[,] matriz = new int[5, 2];
            //for (int x = 0; x < matriz.GetLength(0); x++)
            //{
            //    for (int y = 0; y < matriz.GetLength(1); y++)
            //    {
            //        matriz.SetValue(x+y+1, x, y);

            //        Console.WriteLine("O valor do índice " + x + "," + y + " da matriz é " + matriz[x, y] + " ");
            //    }
            //}
            //Console.ReadKey();

            //15
            //MetodoSemRetorno(); //Control K+C = comenta //Control K+U = descomenta

        }

        /*private static void MetodoSemRetorno()
        {
            Console.WriteLine("Ok, vamos lá!!!");
            Console.ReadKey();

            // Classe Animal
            Animal dog = new Animal();
            dog.nome = "Dogão";
            dog.idade = 12;
            dog.latir("alemão");

        }*/


        class OutraClasse
        {
            string atributo;
        }
    }

    public class Animal
    {
        public string nome;
        protected string raca;
        internal int idade;
        private string porte;

        public void latir(string raca)
        {
            this.raca = raca;
        }
    }
}
