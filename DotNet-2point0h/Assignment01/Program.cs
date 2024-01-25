using System;

namespace Assignment01
{
    class Bank {
        //==============Attributes===============
        //name: string
        public string Name {get; set;}
        //AccountList: BankAccount[]
        public BankAccount[] AccountList

        //nextopenindex: int
        public int NextOpenIndex //tracks next available index in account list array

        //==============Methods==================

        //bank(bankName: string, maxNumAccounts: int)
        public Bank(string bankName, int maxNumAccounts){
            this.Name = bankName
            this.AccountList.length = maxNumAccounts
        }

        //bank(bankName: string, bankAccounts: BankAccount[])
        public Bank(string bankName, ){
            
        }
        //AddAccount(account: BankAccount): bool
        //Transfer(accTransferFrom: BankAccount, accTransferTo: BankAccount, amount: decimal): bool
        //AccountEcists(accountNumber: string): bool
        //Capacity(): int
    }

    class BankAccount{
        //==============Attributes===============
        // MaxNegativeAmount: decimal = -50 {get; private set}
        public decimal MaxNegativeAmount = -50
        // HoldingBank: Bank
        public Bank HoldingBank
        // AccountNumber: string
        public string AccountNumber
        // Balance: decimal
        public decimal Balance

        //==============Methods==================
        //BankAccount(holdingBank: Bank, accountNum: string)
        public BankAccount(){
            throw new InvalidOperationException("Cannot create account: The bank has no room for new accounts.")
        }
        //BankAccount(holdingBank: Bank, accountNum: string, accountBalance: decimal)
        //Deposit(amount: decimal): void
        //Withdraw(amount: decimal): decimal
        //CheckBalance(): decimal
        //GetMaxNegativeAmount(): decimal
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("=================== PROMPT 1 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 1 END ===================\n");


            Console.WriteLine("=================== PROMPT 2 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 2 END ===================\n");


            Console.WriteLine("=================== PROMPT 3 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 3 END ===================\n");


            Console.WriteLine("=================== PROMPT 4 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 4 END ===================\n");


            Console.WriteLine("=================== PROMPT 5 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 5 END ===================\n");


            Console.WriteLine("=================== PROMPT 6 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 6 END ===================\n");


            Console.WriteLine("=================== PROMPT 7 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 7 END ===================\n");


            Console.WriteLine("=================== PROMPT 8 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 8 END ===================\n");


            Console.WriteLine("=================== PROMPT 9 BEGIN ===================");

            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 9 END ===================\n");
        }
    }
}
