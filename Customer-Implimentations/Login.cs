using SecurefirstBank.Account_Implimentations;
using SecurefirstBank.Customer_Implimentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank
{
    internal class Login : HelpForLogin
    {
        public static string mail;
        public static  string pwd;

        public static void LogMeIn()
        {
            var MyCustomerList = ReadFromCustomerFile("CustomerFile.txt");

            Console.WriteLine("\n\n-----------------WELCOME TO LOGIN PORTAL----------------");
            Console.Write("Enter your mail>>>");
            mail = Console.ReadLine();

            Console.Write("Enter your password>>>");
            pwd = Console.ReadLine();

            var UserExist = MyCustomerList.FirstOrDefault(customer => customer.Email == mail && customer.Password == pwd);

            if (UserExist != null) 
            {
                Console.WriteLine("Login Successful!");
                //take the person to his/her dashboard
                var theDashBoard = new DashBoard();
                theDashBoard.MyDashBoard();
            }
            else
            {
                Console.WriteLine("Wrong Password or email.");
                LogMeIn();
            }

        }
    }
    
}

