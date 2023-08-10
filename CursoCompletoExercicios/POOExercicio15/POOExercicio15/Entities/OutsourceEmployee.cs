namespace POOExercicio15.Entities {
    internal class OutsourceEmployee : Employee {

        public double AdditionalCharge { get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(string name, int number, double valuePerHour, double additionalCharge) 
            : base(name, number, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            return base.Payment() + (1.1 * AdditionalCharge);
        }
    }
}
