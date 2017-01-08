using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTest
{
    interface IAplicacaoFactory
    {
        IInvestimento ObtemValorInvestimento(string tipoInvestimento);
    }
}
