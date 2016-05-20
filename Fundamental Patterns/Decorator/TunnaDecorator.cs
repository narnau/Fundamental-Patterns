namespace Fundamental_Patterns.Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TunnaDecorator : Decorator
    {
        private string tunnaType { get; set; }
        private IPizza addedState { get; }

        public TunnaDecorator(IPizza pizza) : base(pizza)
        {
            this.addedState = pizza;
        }
        public void SetTunnaType(string tunnaType)
        {
            this.tunnaType = tunnaType;
        }

        public override decimal GetPrice()
        {
            return this.addedState.GetPrice() + 5.50m;
        }
    }
}
