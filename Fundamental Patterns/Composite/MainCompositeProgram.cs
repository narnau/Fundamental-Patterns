using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Composite
{
    public class MainCompositeProgram
    {
        public void Run()
        {
            Console.WriteLine("Composite pattern example:");
            Console.WriteLine();

            IUIWindow browserWindow = new UIWindow();
            IUIWindow calculatorWindow = new UIWindow();
            IUIWindow wordProcessorWindow = new UIWindow();

            ICompositeWindow mainWorkspace = new CompositeWindow();

            mainWorkspace.Add(browserWindow);
            mainWorkspace.Add(calculatorWindow);
            mainWorkspace.Add(wordProcessorWindow);

            mainWorkspace.Resize();
            Console.WriteLine();
        }
    }
}
