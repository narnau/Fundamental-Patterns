﻿using Fundamental_Patterns.Memento;
using Fundamental_Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Memento pattern
            CareTaker CareTaker = new CareTaker();
            CareTaker.Run();

            //Observer pattern
            MainObserverProgram MainObserverProgram = new MainObserverProgram();
            MainObserverProgram.Run();
        }
    }
}