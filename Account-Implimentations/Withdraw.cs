﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurefirstBank.Interface.Account_Interface;

namespace SecurefirstBank.Account_Implimentations
{
    internal class Withdraw : helper, IWithdraw
    {
        public void WithdrawMoney()
        {

            var mylistOfAccounts = ReadFromAccountFile("AccountFile.txt");
            Console.WriteLine("Enter AccountNumber");
            string AccountNumber = Console.ReadLine();

            Console.WriteLine("Enter Amount To Withdraw");
            decimal Amount = decimal.Parse(Console.ReadLine());

            var accountExist = mylistOfAccounts.FirstOrDefault(account => account.AccNo == AccountNumber);
            if (accountExist is null)
            {
                Console.WriteLine("Wrong Account Number supplied!");
            }
            else
            {
                accountExist.AccBal -= Amount;
                Console.WriteLine("\n Withdrawl Successful!");
            }

            using (var writer = new StreamWriter("AccountFile.txt", false))
            {
                foreach (var account in mylistOfAccounts)
                {
                    writer.WriteLine($"| {account.Fullname} | {account.AccNo} | {account.AccType} | {account.AccBal} |");

                }

            }

            Console.ReadKey();
        }
    }
}

