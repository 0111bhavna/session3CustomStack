using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICustomStack: ICustomStackReadonly<T>
    {
        IIntern Pop();
    }

    public interface ICustomStackReadonly<T>
    {
        void Push(IIntern intern);
        int count();
    }
}
