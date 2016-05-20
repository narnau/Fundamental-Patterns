using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Decorator
{
    public abstract class Decorator : IPizza
    {
        private IPizza pizza;

        protected Decorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public abstract decimal GetPrice();
    }
}