using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Program
    {
        public static double Calculo(double B, double E)
        {
            if (E == 1)
            {
                return B;
            }
            else {
                return B * Calculo(B, E - 1);
            }
        }
        public static double IMC(double H, double P)
        {
            return P / Calculo (H, 2);
        }
        
        static void Main(string[] args)
        {
            string name;
            double peso,altura;
            double imc;

            Console.WriteLine("Escreva seu nome: ");
            name = Console.ReadLine();

            Console.WriteLine($"{name} Entre com sua altura:");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} Entre com sua peso:");
            peso = double.Parse(Console.ReadLine());

            imc = IMC(altura, peso);
            Console.WriteLine($"{name} seu Indice de masa corporal: {imc}");

            Console.ReadKey();
        }
    }
}
