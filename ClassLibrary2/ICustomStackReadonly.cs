using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    

    public interface ICustomStackReadonly<T>
    {
        void Push(IIntern intern);
        int count();
    }
}
