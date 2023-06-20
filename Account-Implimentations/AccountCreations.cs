using SecurefirstBank.Interface.Account_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecurefirstBank.Account_Implimentations
{
    public class AccountCreations: IAccountCreation
    {
        public static string FullName ="";
        public static string AccountNumber ="";
        public static string AccountType = "";
        public static decimal AccountBalance = 0;
       

        public void AccountSetup()
        {

            FullName = CustomerSignUP.Names;

            Random random = new Random();
            //var accNo = "30" +.Next(30789509, 2456007809);
            var accNo = random.Next(20000000,267990000);
           var newAccNo =accNo.ToString();
            AccountNumber =newAccNo;

            Console.Clear();
            Console.WriteLine("Press 1 for savings\nPress 2 for current");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            if (choice == "1") 
            { 
                AccountType = "Savings";
                Console.WriteLine("Please put at least 1000 naira into your account");
                AccountBalance = decimal.Parse(Console.ReadLine());
            }
            else if (choice == "2")
            {
                AccountType = "Current";
                AccountBalance = 0;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                AccountSetup();
            }



            using (var writer = new StreamWriter("AccountFile.txt",true))
            {
                writer.WriteLine($"| {FullName} | {AccountNumber} | {AccountType} | {AccountBalance} |");
            }

            Console.WriteLine("Congratulations On Your Account Opening");
            Console.ReadKey();
        }

    }
}
