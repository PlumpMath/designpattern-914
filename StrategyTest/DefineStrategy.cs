using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTest
{
    public class DefineStrategy
    {
        public IStrategyCalculator definedStrategy;

        public DefineStrategy(IStrategyCalculator strategy)
        {
            definedStrategy = strategy;
        }

        public double Operation(double valor1, double valor2)
        {
            return definedStrategy.Calcular(valor1, valor2);
        }
    }
}
