using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, maior = 0, menor = 0;

            do
            {
                Console.WriteLine("Informe um número: ");
                num = int.Parse(Console.ReadLine());
                if (num > maior)//se o numero for maior que o maior
                {
                    maior = num;//variavel armazena o maior valor dentre os lidos
                }
                else
                {
                    if (num < menor)//se o valor for menor que o menor
                    {
                        menor = num;//variavel armazena o menor dentre os lidos
                    }
                }
            } while (num > 0);//enquanto o usuario nao digitar o negativo
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);

            Console.ReadKey();
        }
        
    }
}
