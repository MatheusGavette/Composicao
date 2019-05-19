using Composicao.Entities;
using Composicao.Entities.Enum;
using System;
using System.Globalization;


namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double salarioBase;

            Console.WriteLine("Insira o nome do Departemento:");
            Department name = new Department { Name = Console.ReadLine() };

            Console.WriteLine("Insira as informações do trabalhador:");

            Console.Write("Nome: ");
            nomeFuncionario = Console.ReadLine();

            Console.Write("Salário Base: ");
            salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Cargo: 1 - Junior | 2 - Pleno | 3 - Senior");
            WorkerLevel cargo = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Worker func = new Worker(nomeFuncionario, salarioBase, cargo);

            Console.WriteLine("-------------");

            Console.WriteLine("Quantos contratos o funcionário está trabalhando");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberContracts; i++)
            {
                Console.Write("Informe a data: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe o valor hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Horas trabalhadas: ");
                int horaTrabalhada = int.Parse(Console.ReadLine());
                
            }

            Console.Write("Entre com o mês de cálculo de salário: ");
            DateTime mes = DateTime.Parse(Console.ReadLine());


        }
    }
}
