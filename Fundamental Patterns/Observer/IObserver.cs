﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Observer
{
    public interface IObserver
    {
        void Notify(SubjectEvent PersonalEvent);
    }
}
