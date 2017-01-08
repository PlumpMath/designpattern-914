using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CitiSavingsAccount : ISavingAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }
}
