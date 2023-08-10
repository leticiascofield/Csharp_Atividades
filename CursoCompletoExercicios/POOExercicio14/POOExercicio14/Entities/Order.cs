﻿using System;
using System.Collections.Generic;
using POOExercicio14.Entities.Enums;

namespace POOExercicio14.Entities {
    internal class Order {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {  
            Items.Remove(item); 
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();
            }
            return total;
        }
    }
}
