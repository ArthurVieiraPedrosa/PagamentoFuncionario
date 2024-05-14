using System;
using System.Collections.Generic;
using PagamentoFuncionairo.Entites;
using System.Globalization;

namespace PagamentoFuncionairo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> list = new List<Funcionario>();
    
            Console.WriteLine("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do funcionário {i}");
                Console.WriteLine("É tercerizado (s/n)?");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite as horas: ");
                int horas = int.Parse(Console.ReadLine());  

                Console.WriteLine("Digite o valor por hora: R$ ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 's')
                {
                    Console.WriteLine("Digite o valor da despesa adicional: R$");
                    double cobrancaAdicional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new FuncionarioTercerizado(nome, horas, valorPorHora, cobrancaAdicional));
                }
                else
                {
                    list.Add(new Funcionario(nome, horas, valorPorHora));
                }
            
            }

            Console.WriteLine("\nPagamentos:");
            foreach (Funcionario emp in list)
            {
                Console.WriteLine($"{emp.Nome} - {emp.Pagamento().ToString("F2",CultureInfo.InvariantCulture)} ");
            }


        }
    }
}

