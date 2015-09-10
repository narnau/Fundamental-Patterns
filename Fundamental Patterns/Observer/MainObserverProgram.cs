using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Observer
{
    public class MainObserverProgram
    {
        public ISubject ConcreteSubject1;
        private ISubject ConcreteSubject2;
        private IObserver ObserverA;
        private IObserver ObserverB;

        public MainObserverProgram()
        {
            //Scenario creation
            this.ConcreteSubject1 = new Subject(0, "Concrete Subject 1");
            this.ConcreteSubject2 = new Subject(1, "Concrete Subject 2");

            this.ObserverA = new ConcreteObserverA();
            this.ObserverB = new ConcreteObserverB();

            ConcreteSubject1.AttachObserver(ObserverA);
            ConcreteSubject1.AttachObserver(ObserverB);

            ConcreteSubject2.AttachObserver(ObserverA);
        }

        public void Run()
        {
            Console.WriteLine("Observer pattern example:");
            Console.WriteLine();
            this.ConcreteSubject1.State = "State 1";
            this.ConcreteSubject2.State = "State 2";
            Console.ReadLine();
        }
        

        
    }
}
