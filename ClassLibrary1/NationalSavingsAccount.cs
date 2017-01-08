using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NationalSavingsAccount : ISavingAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }
}
