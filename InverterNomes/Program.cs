using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.Write("Digite o nome 1#: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome 2#: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome 3#: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o nome 4#: ");
            nome4 = Console.ReadLine();

            // Mecanismo para inverter os nomes

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = nome1;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;

            Console.WriteLine();
            Console.WriteLine("Nomes inseridos na ordem invertida:");
            Console.WriteLine("Primeiro nome invertido:" + nome1);
            Console.WriteLine("Segundo nome invertido:" + nome2);
            Console.WriteLine("Terceiro nome invertido:" + nome3);
            Console.WriteLine("Quarto nome invertido:" + nome4);

            Console.ReadKey();
        }
    }
}
