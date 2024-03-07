class BankAccount{
        //==============Attributes==============={
        // MaxNegativeAmount: decimal = -50 {get; private set
        decimal MaxNegativeAmount { 
            public get { return MaxNegativeAmount; }
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
                throw new InvalidOperationException("Cannot create account: The bank has no room for new accounts.")
            }
            this.HoldingBank = holdingBank;
            this.AccountNumber = accountNum;

            holdingBank.AddAccount(this);
        }
        //BankAccount(holdingBank: Bank, accountNum: string, accountBalance: decimal)
        public BankAccount(Bank holdingBank, string accountNum, decimal accountBalance){
            if(0 >= holdingBank.Capacity()){
                //out of room
                throw new InvalidOperationException("Cannot create account: The bank has no room for new accounts.")
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
            this.Balance -= amount;
        }
        //CheckBalance(): decimal
        public decimal CheckBalance(){
            return this.Balance;
        }
        //GetMaxNegativeAmount(): decimal
        public decimal GetMaxNegativeAmount(){

        }
    }