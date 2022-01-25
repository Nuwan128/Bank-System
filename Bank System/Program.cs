using System;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool iscontinue = true;
            while (iscontinue)
            {
                Console.WriteLine("\n\t-----------------\n\t---Bank System---\n\t-----------------\n");
                Console.WriteLine("Do You Want To Enter The Bank System (yes/no)?");
                var iscountinuResponse = Console.ReadLine();
                if (iscountinuResponse == "no")
                {
                    iscontinue = false;
                }
                else if (iscountinuResponse == "yes")
                {
                    bool goToHome = true;
                    do
                    {                        
                        Console.WriteLine("\n\t1.Admin");
                        Console.WriteLine("\t2.Account Holder\n");

                        Console.WriteLine("Enter Your Choice (1/2)?");
                        var choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Enter Password:");
                            var password = Convert.ToInt32(Console.ReadLine());
                            if (password == 123456)
                            {
                                bool isFinish = true;
                                do
                                {
                                    Console.WriteLine("\n\t1.Creat Accounts");
                                    Console.WriteLine("\t2.Delete Accounts");
                                    Console.WriteLine("\t3.Bank Details\n");

                                    Console.WriteLine("Enter Your Choice (1/2/3)?");
                                    var adminResponse = Convert.ToInt32(Console.ReadLine());
                                    if (adminResponse == 1)
                                    {
                                        bank.creatAccounts();
                                    }
                                    else if (adminResponse == 2)
                                    {
                                        bank.delteAccount();
                                    }
                                    else if (adminResponse ==3)
                                    {
                                        bank.BankDetails();
                                    }
                                    else
                                        Console.WriteLine("---Invalid Input---");

                                    Console.WriteLine("\nFinish Admin setings (yes/no)");
                                    var isFinishingResponse = Console.ReadLine();
                                    if (isFinishingResponse == "yes")
                                    {
                                        isFinish = false;
                                    }
                                    else if (isFinishingResponse =="no")
                                    {
                                        isFinish = true;
                                    }
                                    else
                                        Console.WriteLine("---Invalid Input---");

                                } while (isFinish);

                            }
                            else
                                Console.WriteLine("---Invalid Input---");

                        }
                        else if (choice == 2)
                        {

                        }
                        else
                            Console.WriteLine("---Invalid Input---");

                        Console.WriteLine("\n\t1.Back To Menu\n\t2.Exit\n");
                        Console.WriteLine("Enter Choice (1/2)?");

                        var goToHomeResponse = Convert.ToInt32(Console.ReadLine());
                        if (goToHomeResponse == 1)
                        {
                            goToHome = true;
                        }
                        else if(goToHomeResponse == 2)
                        {
                            goToHome = false;
                        }
                        else
                            Console.WriteLine("---Invalid Input---");

                    } while (goToHome);
                    

                }
                else
                    Console.WriteLine("---Invalid Input---");


            }
        }
    }
    class Bank
    {
        double Capital = 0;
        List<Account> account = new List<Account>();
        public void creatAccounts()
        {
            bool iscreat = true;
            while (iscreat)
            {
                Console.WriteLine("Do you want to creat account (yes/no)?");
                var iscreatResponse = Console.ReadLine();
                if (iscreatResponse == "no")
                {
                    iscreat = false;
                }
                else if (iscreatResponse == "yes")
                {
                    Console.WriteLine("---Enter Account Details---");
                    Console.WriteLine("Name:-");
                    var Name = Console.ReadLine();

                    Console.WriteLine("Account Number:-");
                    var AccountNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Balance:-");
                    var Balance = Convert.ToDouble(Console.ReadLine());

                    account.Add(new Account(Name,AccountNumber,Balance));
                    Capital += Balance;
                }
                else
                    Console.WriteLine("---Invalid Input---");
            }
            

        }
        public void delteAccount()
        {

        }
        public void BankDetails()
        {
            foreach(var person in account)
            {
                Console.WriteLine($"{person.Name}   {person.AccountNumber}  {person.Balnace}");
            }
            Console.WriteLine($"Bank Capital is : Rs{Capital}");
        }
    }
    class Account
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double Balnace { get; set; }
        public Account(string name,int accountnumber, double balance)
        {
            Name = name;
            AccountNumber = accountnumber;
            Balnace = balance;

        }
    }
}
