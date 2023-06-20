using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurefirstBank.Model;

namespace SecurefirstBank.Account_Implimentations
{
    internal class helper
    {
        public  List<Account> ReadFromAccountFile(string filepath)
        {
            List<Account> MyAccountslist = new List<Account>();
            string line;
            using (var reader = new StreamReader(filepath))
            {
                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');
                    if (fields.Length >=4)
                    {
                        var name = fields[1].Trim();
                        var accNo = fields[2].Trim();
                        var accType = fields[3].Trim();
                        var accBal = decimal.Parse(fields[4].Trim());
                        Account myAccount = new Account(name, accNo, accType, accBal);
                        MyAccountslist.Add(myAccount);
                    }
                   
                }
            }
            return MyAccountslist;

        }
    }
}
