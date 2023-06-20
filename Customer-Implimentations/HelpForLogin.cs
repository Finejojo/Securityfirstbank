using SecurefirstBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank.Customer_Implimentations
{
    internal class HelpForLogin
    {
        public static List<Customer> ReadFromCustomerFile(string filepath)
        {
            List<Customer> MyCustomerlist = new List<Customer>();
            string line;
            using (var reader = new StreamReader(filepath))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');
                    if (fields.Length >= 4)
                    {
                        var fullname = fields[1].Trim();
                        var email = fields[2].Trim();
                        var password = fields[3].Trim();
                        
                        Customer customer = new Customer(fullname,email,password);
                        MyCustomerlist.Add(customer);
                    }

                }
            }
            return MyCustomerlist;

        }
    }
}
