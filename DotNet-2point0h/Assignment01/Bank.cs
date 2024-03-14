//c# 1.26.0
namespace Assignment01{
    class Bank {

        //==============Attributes===============
        //name: string
        public string Name {get; set;}
        //AccountList: BankAccount[]
        public BankAccount[] AccountList {get; set;}

        //nextopenindex: int
        public int NextOpenIndex {get; set;} //tracks next available index in account list array

        //==============Methods==================

        //bank(bankName: string, maxNumAccounts: int)
        public Bank(string bankName, int maxNumAccounts){
            this.Name = bankName;
            this.AccountList.length = maxNumAccounts;
        }

        //bank(bankName: string, bankAccounts: BankAccount[])
        public Bank(string bankName, BankAccount[] bankAccounts){
            this.Name = bankName;
            this.AccountList = bankAccounts;
            //TODO: next open index i guess?            
        }
        //AddAccount(account: BankAccount): bool
        public bool AddAccount(BankAccount account){

        }
        //Transfer(accTransferFrom: BankAccount, accTransferTo: BankAccount, amount: decimal): bool
        public bool Transfer(BankAccount accTransferFrom, BankAccount accTransferTo, decimal amount){

        }
        //AccountEcists(accountNumber: string): bool
        public bool AccountExists(string accountNumber){

        }
        //Capacity(): int
        public int Capacity(){

        }
        
    }
}