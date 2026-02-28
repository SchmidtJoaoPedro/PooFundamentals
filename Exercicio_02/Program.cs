using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0, op2 = 0;
            string nomeProduto = "";
            double valorProduto = 0;
            string formaPagamento = "";
            do
            {
                Console.WriteLine("1.None do Produto");
                Console.WriteLine("2.Valor do Produto");
                Console.WriteLine("3.Forma do Pagamento");
                Console.WriteLine("4.Mostrar Dados da Compra");
                Console.Write("5.Sair");
                Console.WriteLine("Escolha sua opcão: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("1.None do Produto");
                        nomeProduto = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("2.Valor do Produto");
                        valorProduto = double.Parse(Console.ReadLine());

                        break;
                    case 3:
                        Console.WriteLine("3.Forma do Pagamento");
                        do
                        {
                            Console.WriteLine("1.Dinheiro");
                            Console.WriteLine("3.Pix");
                            Console.WriteLine("Cartão");

                            Console.WriteLine("Escolha sua opção:");
                            op2 = int.Parse(Console.ReadLine());
                            switch (op2)
                            {
                                case 1:
                                    formaPagamento = "Dinheiro";
                                    break;
                                case 2:
                                    formaPagamento = "Pix";
                                    break;

                                case 3:
                                    formaPagamento = "Cartão";    
                                    break;
                                case 4:
                                    Console.WriteLine("Saindo...");
                                    break;
                            }
                        } while (op2 != 4);
                        break;

                    case 4:
                        Console.WriteLine($"Produto: {nomeProduto}\n Valor: {valorProduto}\n Forma de Pagamento");
                        Console.ReadKey();
                        break;
                    case 5:

                        break;
                }
            } while (op != 5);
        }

    }
}
