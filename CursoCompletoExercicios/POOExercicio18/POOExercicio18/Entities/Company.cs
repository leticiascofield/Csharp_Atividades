using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExercicio18.Entities {
    internal class Company : TaxPayer {

        public int EmployeeCount { get; set; }

        public Company() { }

        public Company(string name, double annualIncome, int employeeCount)
            : base(name, annualIncome) {
            EmployeeCount = employeeCount;
        }

        public override double Tax() {
            double tax = 0;
            if(EmployeeCount > 10) {
                tax = 0.14;
            } else {
                tax = 0.16;
            }
            return AnnualIncome * tax;
        }
    }
}
