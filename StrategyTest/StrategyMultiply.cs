﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTest
{
    public class StrategyMultiply : IStrategyCalculator
    {
        public double Calcular(double valor1, double valor2)
        {
            return valor1 * valor2; 
        }
    }
}
