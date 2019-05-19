using Composicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public WorkerLevel Level { get; set; }

        public Worker (string funcName)
        {
            Name = funcName;
        }
        public Worker (string funcName, double baseSalary) : this (funcName)
        {
            Name = funcName;
            BaseSalary = baseSalary;
        }

        public Worker (string funcName, double baseSalary, WorkerLevel cargo) : this (funcName, baseSalary)
        {
            Level = cargo;
        }

        public void AddContract (DateTime date, double valuePerHour, int hours)
        {
            HourContract contract = new HourContract(date, valuePerHour, hours);
        }

        public void RemoveContract (HourContract contract)
        {
            
        }

        public double Income (int year, int month)
        {
            return BaseSalary;
        }


    }
}
