using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public interface ConsoleUI
    {
        //Change name  or bridge with function for file output 
        public static void PrintData(string message)
        {
            Console.WriteLine($"{message}");
        }

        public static string UserInput() 
        {
            return Console.ReadLine();
        }
            

    }
}
