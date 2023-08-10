using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExercicio18.Entities {
    internal class Individual : TaxPayer {

        public double HealthcareExpenses { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome, double healthcareExpenses)
            : base(name, annualIncome) {
            HealthcareExpenses = healthcareExpenses;
        }

        public override double Tax() {
            double tax = 0;
            if (AnnualIncome < 20000.0) {
                tax = 0.15;
            } else {
                tax = 0.25;
            }
            return (AnnualIncome * tax) - (HealthcareExpenses * 0.5); 
        }
    }
}
