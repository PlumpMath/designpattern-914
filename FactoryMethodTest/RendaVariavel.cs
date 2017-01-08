using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTest
{
    public class RendaVariavel : IInvestimento
    {
        public decimal ValorAplicar
        {
            get
            {
                return 5000;
            }
        }
    }
}
