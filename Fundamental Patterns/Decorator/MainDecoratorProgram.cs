using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Decorator
{
    public class MainDecoratorProgram
    {
        public MainDecoratorProgram()
        {
            
        }

        public void Run()
        {
            var concretePizza = new ConcretePizza();
            Console.WriteLine("Pizza price {0}", concretePizza.GetPrice());

            var tunnaPizza = new TunnaDecorator(concretePizza);
            Console.WriteLine("Tunna pizza Price {0}", tunnaPizza.GetPrice());
            
        }
    }
}
