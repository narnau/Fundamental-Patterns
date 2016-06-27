using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Composite
{
    public interface IComposite<TEntity, in TIdType>
        where TEntity : class
    {
        void Add(TEntity entity);
        void Remove(TIdType id);
        TEntity GetChild(TIdType type);
    }
}
