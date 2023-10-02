using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class Validate
    {

        public static bool Input<T>(T, Func<bool> ParametersAndConditions)
        {
            var valid = false;
            do
            {
                valid = ParametersAndConditions();
            } while (valid == false);

            return valid;
        }

    }
}
