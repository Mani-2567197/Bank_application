using System;

namespace BankApplication
{
    public class BankAccount
    {
       private string AccountNumber;
       private string AccountHolderName;
       private double Balance = 0.0;
        public BankAccount(string AccountNumber, string accountHolderName, double balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }
        public string accountNumber
        {
            get { return AccountNumber; } 
        }
        public double balance
        {
            set { Balance = value; }
        }
        public string accountholdername
        {
            get { return AccountHolderName; }
        }

        public void Deposit(double balance)
        {
            this.Balance+= balance;
            Console.WriteLine($"Rs.{balance} Has been Credited into {accountNumber} on {DateTime.Now} & your Avail.Bal: Rs.{Balance}");

        }
        public void GetBalance(string accountHolderName)
        {
            if(accountHolderName == "Ram")
            {
                Console.WriteLine("Current Balance:"+Balance);
            }
        }
        public void WithDraw(double balance)
        {
            this.Balance-= balance;
            Console.WriteLine($"Rs.{balance} Has been Debited from {accountNumber} on {DateTime.Now} & your Avail.Bal: Rs.{Balance}");
        }
        public void PrintDetails()
        {
            string choose;
            Console.WriteLine("*** Welcome to My Bank ***");
            Console.WriteLine("Account No :"+accountNumber);
            Console.WriteLine("Name:\t"+accountholdername);
            GetBalance("Admin@1234");
            try
            {
                do
                {
                    
                    Console.WriteLine("1.Deposit  2.WithDraw ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the Deposit Amount");
                            double depo = double.Parse(Console.ReadLine());
                            Deposit(depo);
                            break;
                        case 2:
                            Console.WriteLine("Enter the WithDraw Amount");
                            double debit = double.Parse(Console.ReadLine());
                            WithDraw(debit);
                            break;
                        default:
                            Console.WriteLine("Please select correct transaction method:");
                            break;

                    }
                    Console.WriteLine("Do u wanna Continue the Transactions press Y to exit press any key...");
                    choose=Console.ReadLine();
                }
                while (choose == "y");

            }
            catch(FormatException f)
            {
                Console.WriteLine("Invalid input format");
            }
            finally
            {
                Console.WriteLine("*** Thanks For Visiting ***");
            }
           
        }
    }
}
