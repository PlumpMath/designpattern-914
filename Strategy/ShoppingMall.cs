using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ShoppingMall
    {
        public string CustomerName { get; set; }
        public int BillAmout { get; set; }

        public IStrategy CurrentStrategy;
        public ShoppingMall(IStrategy newStrategy)
        {
            CurrentStrategy = newStrategy;
        }

        public int GetFinalBill()
        {
            return CurrentStrategy.GetFinalBill(this.BillAmout);
        }
    }
}
