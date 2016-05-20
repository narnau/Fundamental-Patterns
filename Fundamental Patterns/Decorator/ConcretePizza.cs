﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Decorator
{
    public class ConcretePizza : IPizza
    {
        public decimal GetPrice()
        {
            return 15m;
        }
    }
}
