using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Observer
{
    public class Subject : ISubject
    {
        public IList<IObserver> Observers{ get; set;}
        public SubjectEvent SubjectEvent { get; set; }
        private string state { get; set; }
        public string State
        {
            get
            {
                return this.State;
            }
            set
            {
                this.state = value;
                this.Notify();
            }
        }

        public Subject(int type, string subject)
        {
            this.Observers = new List<IObserver>();
            this.SubjectEvent = new SubjectEvent(type, subject);
        }

        public void AttachObserver(IObserver Observer)
        {
            this.Observers.Add(Observer);
        }

        public void DetachObserver(IObserver Observer)
        {
            this.Observers.Remove(Observer);
        }

        public void Notify()
        {
            foreach (var observer in this.Observers)
            {
                observer.Notify(this.SubjectEvent);

            }
        }
    }
}
