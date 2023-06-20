using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurefirstBank.Interface.Account_Interface;

namespace SecurefirstBank.Account_Implimentations
{
    internal class Transfer : helper, ITransfer
    {
        public void TransferMoney()
        {
            var mylistOfAccounts = ReadFromAccountFile("AccountFile.txt");
            Console.WriteLine("Enter AccountNumber you are SENDING FROM");
            string GiverAccountNo = Console.ReadLine();

            Console.WriteLine("Enter AccountNumber you are SENDING TO");
            string ReceiverAccountNo = Console.ReadLine();

            Console.WriteLine("Enter Amount To Transfer");
            decimal Amount = decimal.Parse(Console.ReadLine());

            var giverExist = mylistOfAccounts.FirstOrDefault(account => account.AccNo == GiverAccountNo);
            var receiverExist = mylistOfAccounts.FirstOrDefault(account => account.AccNo == ReceiverAccountNo);

            if (giverExist is null || receiverExist is null || Amount < 1)
            {
                Console.WriteLine("Wrong Account Number supplied!");
            }
            else
            {
                giverExist.AccBal -= Amount;
                receiverExist.AccBal += Amount;
                Console.WriteLine("\n Transfer Successful!");
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

