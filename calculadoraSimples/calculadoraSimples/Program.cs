using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.WriteLine("Bem-vindo(a) a calculadora simples! \nQual operação deseja realizar?");
            Console.Write("+ - x /");    
            
            //escolhendo a operacao
            char operacao = char.Parse(Console.ReadLine());
            
            //recebendo dados para operacao
            Console.Write("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());
                       
            double resultado = 0;
            
            switch (operacao)
            {
                default:
                    Console.WriteLine("Digite uma opção válida.");
                    goto Inicio;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é " + resultado);
                    break;
                case 'x':
                case 'X':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é " + resultado);
                    break;
                case '/':
                case ':':

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividirmos por zero.");
                        goto Inicio;

                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é " + resultado);
                        break;

                    }
            }
            Console.Write("Deseja realizar outra operação? \nTecle 's' para sim ou 'n' para não:");
            string continuar = Console.ReadLine();

            if (continuar == "s" || continuar == "S")
            {

                 goto Inicio;

            }

            Console.ReadKey();

           
        }
    }
}
