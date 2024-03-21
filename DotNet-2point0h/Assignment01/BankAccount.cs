using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment01{
    class BankAccount{
        //==============Attributes==============={
        // MaxNegativeAmount: decimal = -50 {get; private set
        public decimal MaxNegativeAmount { 
            get { return MaxNegativeAmount; }
            private set { MaxNegativeAmount = -50; }
        }
        // HoldingBank: Bank
        public Bank HoldingBank {get; set;}
        // AccountNumber: string
        public string AccountNumber {get; set;}
        // Balance: decimal
        public decimal Balance {get; set;}

        //==============Methods==================
        //BankAccount(holdingBank: Bank, accountNum: string)
        public BankAccount(Bank holdingBank, string accountNum){
            if(0 >= holdingBank.Capacity()){
                //out of room
                throw new InvalidOperationException("Cannot create account: The bank has no room for new accounts.");
            }
            this.HoldingBank = holdingBank;
            this.AccountNumber = accountNum;
            this.Balance = 0;

            holdingBank.AddAccount(this);
        }
        //BankAccount(holdingBank: Bank, accountNum: string, accountBalance: decimal)
        public BankAccount(Bank holdingBank, string accountNum, decimal accountBalance){
            if(0 >= holdingBank.Capacity()){
                //out of room
                throw new InvalidOperationException("Cannot create account: The bank has no room for new accounts.");
            }
            this.HoldingBank = holdingBank;
            this.AccountNumber = accountNum;
            this.Balance = accountBalance;

            holdingBank.AddAccount(this);
        }
        //Deposit(amount: decimal): void
        public void Deposit(decimal amount){
            this.Balance += amount;
        }
        //Withdraw(amount: decimal): decimal
        public decimal Withdraw(decimal amount){
            if(this.Balance >= amount){
                return this.Balance -= amount;
            }else{
                Console.WriteLine("This account doesn't have sufficient funds for that operation.");
                return this.Balance;
            }
        }
        //CheckBalance(): decimal
        public decimal CheckBalance(){
            return this.Balance;
        }
        //GetMaxNegativeAmount(): decimal
        public decimal GetMaxNegativeAmount(){
            return MaxNegativeAmount;
        }
    }
}