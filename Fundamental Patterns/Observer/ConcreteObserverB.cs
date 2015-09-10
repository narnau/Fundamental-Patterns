using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Observer
{
    public class ConcreteObserverB : IObserver
    {
        public void Notify(SubjectEvent SubjectEvent)
        {
            Console.WriteLine("ConcreteObserverB");
            Console.WriteLine("Event type: {0} / Subject: {1}", SubjectEvent.type, SubjectEvent.subject);
        }

    }
}
