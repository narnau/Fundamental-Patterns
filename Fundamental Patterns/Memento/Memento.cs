using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Memento
{
    public class Memento
    {
        public String state { get; set; }

        public Memento(String state)
        {
            this.state = state;
        }


    }
}
