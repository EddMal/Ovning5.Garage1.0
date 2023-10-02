using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
     internal interface UserInterface
    {
         void PrintData<T>(T);

         T UserInput<T>();
    }
}
