﻿using System;
using System.Collections.Generic;
using System.Text;
using ContractCalculation.Entities.Enum;

namespace ContractCalculation.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoverContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

<<<<<<< master
        public double Income(int year, int mouth)
=======
                        public double Income(int year, int mouth)

>>>>>>> local
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}