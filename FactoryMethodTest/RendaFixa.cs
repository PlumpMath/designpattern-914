using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTest
{
    public class RendaFixa : IInvestimento
    {
        public decimal ValorAplicar
        {   
            get
            {
                return 10000;
            }
        }
    }
}
