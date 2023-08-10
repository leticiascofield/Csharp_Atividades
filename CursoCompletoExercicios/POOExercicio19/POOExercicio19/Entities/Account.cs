﻿using POOExercicio19.Entities.Exceptions;
using System;


namespace POOExercicio19.Entities {
    internal class Account {
        
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (WithdrawLimit < amount) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance < amount) {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
