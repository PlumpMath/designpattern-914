using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTest
{
    public class AplicacaoFactory : IAplicacaoFactory
    {
        public IInvestimento ObtemValorInvestimento(string tipoInvestimento)
        {
            if (tipoInvestimento.Contains("rendafixa"))
            {
                return new RendaFixa();
            }
            else if (tipoInvestimento.Contains("rendaVariavel"))
            {
                return new RendaVariavel();
            }
            else
            {
              throw new ArgumentException("Tipo de aplicacao invalido");
            } 
        }
    }
}
