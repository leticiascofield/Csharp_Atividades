using System;
using System.Globalization;

namespace POOExercicio14.Entities {
    internal class OrderItem {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price) {
            Quantity = quantity;
            Product.Price = price;
        }

        public double SubTotal() {
            return Quantity * Product.Price;
        }

        public override string ToString() {
            return Product.Name + ", $" + 
                Product.Price.ToString("F2", CultureInfo.InvariantCulture) + 
                ", Quantity: " + Quantity + ", Subtotal: $" + 
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
