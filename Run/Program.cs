using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using FactoryMethod;
using FactoryMethodTest;
using Strategy;
using StrategyTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory Method
            //var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            //var citiAcct = factory.GetSavingAccount("CITI-321");
            //var nationalAcct = factory.GetSavingAccount("NATIONAL-987");

            //Console.WriteLine($"My citi is ${citiAcct.Balance}" + $" and nati is ${nationalAcct.Balance}");
            #endregion

            #region Decorator Pattern
            //Car theCar = new CompactCar();
            //theCar = new LeatherSeats(theCar);

            //Console.WriteLine(theCar.GetDescription());
            //Console.WriteLine($"{theCar.GetCarPrice():C2}");
            //Console.ReadKey();
            #endregion

            #region FactoryEx
            //var fabrica = new AplicacaoFactory();
            //var rv = fabrica.ObtemValorInvestimento("rendavariavel");
            //var rf = fabrica.ObtemValorInvestimento("rendafixa");
            #endregion

            #region Strategy

            //var shopMall = new ShoppingMall(new LowDiscount());
            //shopMall.CustomerName = "Monday Customer";
            //shopMall.BillAmout = 1000;
            //Console.WriteLine("Final bill " + shopMall.GetFinalBill());

            //var shopMall2 = new ShoppingMall(new HighDiscount());
            //shopMall2.CustomerName = "Thursday Customer";
            //shopMall2.BillAmout = 1000;
            //Console.WriteLine("Final bill " + shopMall2.GetFinalBill());

            //var shopMall3 = new ShoppingMall(new NonDiscount());
            //shopMall3.CustomerName = "Saturday Customer";
            //shopMall3.BillAmout = 1000;
            //Console.WriteLine("Final bill " + shopMall3.GetFinalBill());

            #endregion

            #region Strategy Calculator
            
            Console.WriteLine("2 + 5 is: " + Calculate("add", 2, 5));
            Console.WriteLine("2 x 5 is: " + Calculate("multiply", 2, 5));
            Console.WriteLine("5 - 2 is: " + Calculate("subtract", 5, 2));
            Console.WriteLine("10 / 2 is: " + Calculate("divide", 10, 2));
            
            #endregion
        }
                
        public static double Calculate(string tipoOperacao, double valor1, double valor2)
        {


            switch (tipoOperacao)
            {
                case "add":
                    return new DefineStrategy(new StrategyAdd()).Operation(valor1, valor2);
                    break;
                case "divide":
                    return new DefineStrategy(new StrategyDivide()).Operation(valor1, valor2);
                    break;
                case "multiply":
                    return new DefineStrategy(new StrategyMultiply()).Operation(valor1, valor2);
                    break;
                case "subtract":
                    return new DefineStrategy(new StrategySubtract()).Operation(valor1, valor2);
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
