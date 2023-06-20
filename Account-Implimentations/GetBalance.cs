using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank.Account_Implimentations
{
    internal class GetBalance : helper
    {
        public void GetMyBalance()
        {

            var mylistOfAccounts = ReadFromAccountFile("AccountFile.txt");
            Console.WriteLine("Enter AccountNumber");
            string AccountNumber = Console.ReadLine();


            var accountExist = mylistOfAccounts.FirstOrDefault(account => account.AccNo == AccountNumber);

            if (accountExist is null)
            {
                Console.WriteLine("Wrong Account Number supplied!");
            }
            else
            {
                var Balance = accountExist.AccBal;
                Console.WriteLine($"\n Your Account Balance is : {Balance}");
            }

            Console.ReadKey();
        }
    }
}

