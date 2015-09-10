using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Observer
{
    public class SubjectEvent
    {
        public int type { get; set; }
        public string subject { get; set; }

        public SubjectEvent(int type, string subject)
        {
            this.type = type;
            this.subject = subject;
        }
    }
}
