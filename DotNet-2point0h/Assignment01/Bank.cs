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
        public List<BankAccount> AccountList = new List<BankAccount>();

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
            
            return false;
        }
        //Transfer(accTransferFrom: BankAccount, accTransferTo: BankAccount, amount: decimal): bool
        public bool Transfer(BankAccount accTransferFrom, BankAccount accTransferTo, decimal amount){
            bool attempt = true;
            if(AccountExists(accTransferFrom.AccountNumber) == false || AccountExists(accTransferTo.AccountNumber) == false){
                Console.WriteLine("That account doesn't exist.");
                attempt = false;
                return attempt;
            }
            if(accTransferFrom.Balance < amount){
                Console.WriteLine($"There are insufficient funds in account {accTransferFrom.AccountNumber}.");
                attempt = false;
                return attempt;
            }
            if(attempt == true){
                accTransferFrom.Balance -= amount;
                accTransferTo.Balance += amount;
                Console.WriteLine($"Funds successfully transfered from account {accTransferFrom.AccountNumber} to account {accTransferTo.AccountNumber}.");
                return attempt;
            }
            return attempt;
        }
        //AccountEcists(accountNumber: string): bool
        public bool AccountExists(string accountNumber){
            bool exists = false;
            for(int i = 0; i < this.AccountList.Count; i++){
                if(this.AccountList[i].AccountNumber == accountNumber){
                    exists = true;
                    break;
                }
                exists = false;
            };
            return exists;
        }
        //Capacity(): int
        public int Capacity(){
           return (this.AccountList.Capacity - this.AccountList.Count);
        }
        
    }
}