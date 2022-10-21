using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class CustomStack<iIIntern> : ICustomStack<IIntern>
    {
        public IIntern[] arr;
        public int pointer;


        public CustomStack()
        {
            arr = new IIntern[10];
            pointer = 0;
        }

        public void Push(IIntern value)
        {

            arr[pointer] = value;
            pointer++;

        }

        

        public IIntern Pop()
        {
            pointer--;
            IIntern value = arr[pointer];


            return value;
        }

        public int count()
        {
            return pointer;
        }
    }

    public interface ICustomStack<T> : ICustomStackReadonly<IIntern>
    {
        IIntern Pop();
    }

   
}