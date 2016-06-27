using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Composite
{
    public interface IUIWindow : IUIWindowCommands
    {
        Guid Id { get; set; }
    }
}
