using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingAccount GetSavingAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
                return new CitiSavingsAccount();
            else if (acctNo.Contains("NATI"))
                return new NationalSavingsAccount();
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
