using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Composite
{
    public class CompositeWindow : ICompositeWindow
    {
        private readonly IList<IUIWindow> windows;

        public CompositeWindow()
        {
            this.windows = new List<IUIWindow>();
        }

        public void Resize()
        {
            foreach (IUIWindow window in this.windows)
            {
                window.Resize();
            }
        }

        public void Add(IUIWindow window)
        {
            this.windows.Add(window);
        }

        public void Remove(Guid id)
        {
            this.windows.Remove(this.windows.First(x => x.Id.Equals(id)));
        }

        public IUIWindow GetChild(Guid id)
        {
            return this.windows.First(x => x.Id.Equals(id));
        }
    }
}
