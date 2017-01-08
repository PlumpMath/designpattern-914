using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTest
{
    public interface IStrategyCalculator
    {
        double Calcular(double valor1, double valor2);
    }
}
