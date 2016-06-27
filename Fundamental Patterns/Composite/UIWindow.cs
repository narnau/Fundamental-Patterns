using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Composite
{
    public class UIWindow : IUIWindow
    {
        public UIWindow()
        {
            this.Id = Guid.NewGuid();    
        }

        public void Resize()
        {
            Console.WriteLine("Resizing window {0}", this.Id);
        }

        public Guid Id { get; set; }
    }
}
