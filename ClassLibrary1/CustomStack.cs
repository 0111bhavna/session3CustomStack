using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomStack<T> : ICustomStack<T>
    {
        public IIntern[] arr;
        public int pointer;

        public CustomStack()
        {
            arr = new IIntern[10];
            pointer = 0;
        }

        public void Push(T value)
        {
            arr[pointer] = value;
            pointer++;

        }

        public int Count()
        {
            return pointer;
        }

        public IIntern Pop()
        {
            pointer--;
            IIntern value = arr[pointer];


            return value;
        }

    }

}
