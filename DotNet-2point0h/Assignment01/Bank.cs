//c# 1.26.0
using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment01{
    class Bank {

        //==============Attributes===============
        //name: string
        public string Name {get; set;}
        //AccountList: BankAccount[]
        //public BankAccount[] AccountList {get; set;}
        List<BankAccount> AccountList = new List<BankAccount>();

        //nextopenindex: int
        public int NextOpenIndex {get; set;} //tracks next available index in account list array

        //==============Methods==================

        //bank(bankName: string, maxNumAccounts: int)
        public Bank(string bankName, int maxNumAccounts){
            this.Name = bankName;
            this.AccountList.Capacity = maxNumAccounts;
        }

        //bank(bankName: string, bankAccounts: BankAccount[])
        public Bank(string bankName, BankAccount bankAccounts){
            this.Name = bankName;
            //this.AccountList = bankAccounts;
            this.AccountList.Add(bankAccounts);
            //TODO: next open index i guess?            
        }
        //AddAccount(account: BankAccount): bool
        public bool AddAccount(BankAccount account){
            if(this.AccountList.Count < this.AccountList.Capacity){
                foreach (BankAccount acct in AccountList){
                    if(account == acct){
                        Console.WriteLine("This bank already has that account.");
                        return false;
                    }                    
                }
                this.AccountList.Add(account);
                return true;
            }
            Console.WriteLine("This bank has no room for accounts.");
            return false;
        }
        //Transfer(accTransferFrom: BankAccount, accTransferTo: BankAccount, amount: decimal): bool
        public bool Transfer(BankAccount accTransferFrom, BankAccount accTransferTo, decimal amount){
            if(accTransferFrom.Balance < amount){
                Console.WriteLine($"There are insufficient funds in account ${accTransferFrom.AccountNumber}.");
                return false;
            }
            accTransferFrom.Balance -= amount;
            accTransferTo.Balance += amount;
            Console.WriteLine($"Funds successfully transfered from ${accTransferFrom.AccountNumber} to ${accTransferTo.AccountNumber}.");
            return true;
        }
        //AccountEcists(accountNumber: string): bool
        public bool AccountExists(string accountNumber){

        }
        //Capacity(): int
        public int Capacity(){

        }
        
    }
}