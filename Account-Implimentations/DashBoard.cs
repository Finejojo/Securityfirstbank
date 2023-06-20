using SecurefirstBank.Customer_Implimentations;
using SecurefirstBank.Interface.Account_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank.Account_Implimentations
{
    internal class DashBoard
    {
        IDeposit depmoney;
        IWithdraw wthdrw;
        ITransfer tranfr;
        IGetBalance getBalance;
        IAccountCreation accountCreation;
        public DashBoard()
        {
        }

        public DashBoard(IDeposit depmoney, IWithdraw wthdrw , ITransfer tranfr, IGetBalance getBalance , IAccountCreation accountCreation)
        {
            this.depmoney = depmoney;
            this.wthdrw = wthdrw;
            this.tranfr = tranfr;
            this.getBalance = getBalance;
            this.accountCreation = accountCreation;
        }

        public void MyDashBoard() 
        {
            Console.Clear();
            Console.WriteLine("\n\n------------WELCOME TO YOUR DASHBOARD-----------\n");
            Console.WriteLine("Press 1 >> Create Account");
            Console.WriteLine("Press 2 >> Deposit Money");
            Console.WriteLine("Press 3 >> Withdraw Money");
            Console.WriteLine("Press 4 >> Transfer Money");
            Console.WriteLine("Press 5 >> Get Account Balance");
            Console.WriteLine("Press 6 >> Print Account Statement");
            Console.WriteLine("Press 7 >> To log out");

            string choice = Console.ReadLine();
            if (choice == "1" ) 
            {
                //var acccreation = new AccountCreations();
                // acccreation.AccountSetup();
                accountCreation.AccountSetup();
                MyDashBoard();
            }
            else if (choice == "2" )
            {
                //var depmoney = new Deposit();
                //depmoney.DepositMoney();
                depmoney.DepositMoney();
                MyDashBoard();

            }
            else if (choice == "3" )
            {
                //var withdraw = new Withdraw();
                //withdraw.WithdrawMoney();
                wthdrw.WithdrawMoney();
                MyDashBoard();
            }
            else if (choice == "4" )
            {
               // var transfer = new Transfer();
               // transfer.TransferMoney();
               tranfr.TransferMoney();
                MyDashBoard();
            }
            else if(choice == "5" )
            {
                // var getbalance = new GetBalance();
                // getbalance.GetMyBalance();
                getBalance.GetMyBalance();
                MyDashBoard();
            }
            else if (choice =="6" )
            {
                Console.WriteLine("Network is currently unavailable.");
                MyDashBoard();
            }
            else if(choice == "7")
            {
                LogOut.LogMeOut();
            }
            else
            {
                Console.WriteLine("Please Enter a valid choice");
                MyDashBoard();
            }
        }


    }
}
