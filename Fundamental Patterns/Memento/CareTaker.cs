using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Memento
{
    public class CareTaker
    {
        private IList<Memento> StateMemory;
        private Originator OriginalObject;

        public CareTaker()
        {
            this.StateMemory = new List<Memento>();
            this.OriginalObject = new Originator();
        }

        public void Run()
        {
            Console.WriteLine("Memento pattern example:");
            Console.WriteLine();
            this.OriginalObject.Set("State 1");
            this.StateMemory.Add(this.OriginalObject.SaveToMemento(this.OriginalObject.Get()));
            this.OriginalObject.Set("State 2");
            this.OriginalObject.Set("State 3");
            this.OriginalObject.Set("State 4");
            this.StateMemory.Add(this.OriginalObject.SaveToMemento(this.OriginalObject.Get()));

            this.OriginalObject.UndoState(this.StateMemory.Take(1).FirstOrDefault<Memento>());
            var state = this.OriginalObject.Get();
            Console.ReadLine();
        }
    }
}
