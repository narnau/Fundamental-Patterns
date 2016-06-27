using Fundamental_Patterns.Chain_of_Responsability;
using Fundamental_Patterns.Memento;
using Fundamental_Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fundamental_Patterns.Builder;
using Fundamental_Patterns.Composite;
using Fundamental_Patterns.Decorator;

namespace Fundamental_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Memento pattern
            MainMementoProgram mainMementoProgram = new MainMementoProgram();
            mainMementoProgram.Run();

            // Observer pattern  
            MainObserverProgram MainObserverProgram = new MainObserverProgram();
            MainObserverProgram.Run();

            // Chain of responsability pattern 
            MainChainOfResponsabilityProgram mainChainOfResponsabilityProgram = new MainChainOfResponsabilityProgram();
            mainChainOfResponsabilityProgram.Run();

            // Builder pattern
            MainBuilderProgram MainBuilderProgram = new MainBuilderProgram();
            MainBuilderProgram.Run();

            // Decorator pattern
            MainDecoratorProgram mainDecoratorProgram = new MainDecoratorProgram();
            mainDecoratorProgram.Run();

            //Composite pattern
            MainCompositeProgram mainCompositeProgram = new MainCompositeProgram();
            mainCompositeProgram.Run();

            Console.ReadLine();
        }
    }
}
