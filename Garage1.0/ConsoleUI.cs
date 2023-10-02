using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal interface ConsoleUI : UserInterface
    {
        public virtual void PrintData(string message)
        {
            Console.WriteLine("message");
        }

        public virtual string UserInput() 
        {
            return Console.ReadLine();
        }
            

    }
}
