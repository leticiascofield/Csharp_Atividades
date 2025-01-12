﻿using POOExercicio12.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace POOExercicio12.Entities {
    internal class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker () { }

        public Worker (string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contract.Add(contract);
        }

        public void DeleteContract(HourContract contract) {
            Contract.Remove(contract);
        }

        public double Income(int year, int month) {
            double valor = BaseSalary;

            foreach (HourContract contract in Contract) {
                if(contract.Date.Year ==  year && contract.Date.Month == month) {
                    valor += contract.TotalValue();
                }
            }

            return valor;
        }
    }
}
