using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ThirdSession
{


    public class Program
    {

        static void Main(string[] args)
        {


            CustomStack<Jedi> customStack2 = new CustomStack<Jedi>();
            customStack2.Push(new Jedi("James", 1));
            customStack2.Push(new Jedi("Jane", 2));
            customStack2.Push(new Jedi("Frank", 3));


            CustomStackExtendedOp.DisplayAllInternsNameAndId(customStack2);


            Console.ReadLine();
        }
    }
}