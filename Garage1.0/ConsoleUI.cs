using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public interface ConsoleUI
    {
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
