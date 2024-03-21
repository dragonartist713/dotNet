using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment01
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== PROMPT 1 BEGIN ===================");
            //instantiate a Bank
                  Bank altra = new Bank("Altra",100);

            Console.WriteLine("=================== PROMPT 1 END ===================\n");
		

            Console.WriteLine("=================== PROMPT 2 BEGIN ===================");
		//Create Bank Accounts
                  BankAccount altraAcct1 = new BankAccount(altra, "001", 5);
                  BankAccount altraAcct2 = new BankAccount(altra, "002", 15);
                  BankAccount altraAcct3 = new BankAccount(altra, "003");

            Console.WriteLine("=================== PROMPT 2 END ===================\n");


            Console.WriteLine("=================== PROMPT 3 BEGIN ===================");
		//Deposit Money
                  altraAcct3.Deposit(100);

            Console.WriteLine("=================== PROMPT 3 END ===================\n");


            Console.WriteLine("=================== PROMPT 4 BEGIN ===================");
		//Withdraw Money
            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 4 END ===================\n");


            Console.WriteLine("=================== PROMPT 5 BEGIN ===================");
		//Check Account Balance
            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 5 END ===================\n");


            Console.WriteLine("=================== PROMPT 6 BEGIN ===================");
		//Handle Insufficient Funds
            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 6 END ===================\n");


            Console.WriteLine("=================== PROMPT 7 BEGIN ===================");
		//List all accounts in a bank
            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 7 END ===================\n");


            Console.WriteLine("=================== PROMPT 8 BEGIN ===================");
		//transfer funds between accounts
            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 8 END ===================\n");


            Console.WriteLine("=================== PROMPT 9 BEGIN ===================");
		//bank capacity check
            /* TODO: Write your code here. */

            Console.WriteLine("=================== PROMPT 9 END ===================\n");
        }
    }
}
