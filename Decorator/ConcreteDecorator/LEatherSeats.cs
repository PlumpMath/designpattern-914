using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather Seats";
        }

        public override string GetDescription()
        {
            return $"{_car.GetDescription()}, {Description}";
        }

        public override double GetCarPrice()
        {
            return _car.GetCarPrice() + 2500; 
        }
    }
}
