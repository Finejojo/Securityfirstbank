using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank.Model
{
    internal class Account
    {
        public Account(string fullname, string accNo, string accType, decimal accBal)
        {
            Fullname = fullname;
            AccNo = accNo;
            AccType = accType;
            AccBal = accBal;
        }

        public string Fullname { get; set; }
        public string AccNo { get; set; }
        public string AccType { get; set; }
        public decimal AccBal { get; set; }

    }
}
