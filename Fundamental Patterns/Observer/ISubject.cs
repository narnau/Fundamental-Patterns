using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Observer
{
    public interface ISubject
    {
        IList<IObserver> Observers { get; set; }
        String State { get; set; }

        void AttachObserver(IObserver Observer);
        void DetachObserver(IObserver Observer);
        void Notify();
    }
}
