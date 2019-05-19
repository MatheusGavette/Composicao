using Composicao.Entities.Enum;
using System;
using System.Collections.Generic;
namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string funcName)
        {
            Name = funcName;
        }
        public Worker(string funcName, double baseSalary) : this(funcName)
        {
            Name = funcName;
            BaseSalary = baseSalary;
        }

        public Worker(string funcName, double baseSalary, WorkerLevel cargo) : this(funcName, baseSalary)
        {
            Level = cargo;
        }

        public Worker(string funcName, double baseSalary, WorkerLevel cargo, Department department) : this(funcName, baseSalary, cargo)
        {
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (year == contract.Date.Month && month == contract.Date.Month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;

        }


    }
}
