using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class HighDiscount : IStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return (int)(billAmount - (billAmount * 0.5));
        }
    }
}
