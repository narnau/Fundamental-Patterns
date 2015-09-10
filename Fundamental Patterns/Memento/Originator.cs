using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Memento
{
    public class Originator
    {
        private String _state;

        public void Set(String state)
        {
            this._state = state;
            Console.WriteLine("Originator: Set {0}", state);
        }

        public String Get()
        {
            Console.WriteLine("Originator: Get {0}", this._state);
            return this._state;
        }

        public Memento SaveToMemento(String state)
        {
            return new Memento(state);
        }

        public void UndoState(Memento memento)
        {
            Console.WriteLine("UndoState to {0}", memento.state);
            this._state = memento.state;
        }
    }
}
