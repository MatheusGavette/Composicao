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
            Console.Write("Insira o nome do Departemento:");
            string deptName = Console.ReadLine();

            Console.WriteLine("Insira as informações do trabalhador:");

            Console.Write("Nome: ");
            string nomeFuncionario = Console.ReadLine();

            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Cargo: 1 - Junior | 2 - MidLevel | 3 - Senior");
            WorkerLevel cargo = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Department dept = new Department(deptName);

            Worker worker = new Worker(nomeFuncionario, salarioBase, cargo, dept);

            Console.WriteLine("-------------");

            Console.WriteLine("Quantos contratos o funcionário está trabalhando");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberContracts; i++)
            {
                Console.Write($"Informe a data do contrato {i}: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write($"Informe o valor hora do contrato {i}: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Horas trabalhadas dentro do contrato {i}: ");
                int horaTrabalhada = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valorHora, horaTrabalhada);

                worker.AddContract(contract);

                Console.WriteLine("-----------------");
                
            }

            Console.Write("Entre com o mês e ano (MM/YYYY) desejado para o cálculo de salário: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: {0}", worker.Name);
            Console.WriteLine("Departamento: {0}", worker.Department.Name);
            Console.WriteLine("Cargo: {0}", worker.Level);
            Console.WriteLine("Salário do mês solicitado: {0}", worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
