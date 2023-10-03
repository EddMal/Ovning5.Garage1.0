using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class Validate
    {

        //public static bool Input<T>( Func<T,bool> ParametersAndConditions)
        //{
        //    var valid = false;
        //    do
        //    {
        //        valid = ParametersAndConditions(T);
        //    } while (valid == false);

        //    return valid;
        //}

        public static void SetIntmember( int vehicleParameter, string VehicleInputRules, Func<int, bool> condition)
        {
            UI.PrintData($"{VehicleInputRules}");
            bool valid = false;
            while (valid == false)
            {
                string Input = UI.UserInput();
                int result;
                if (int.TryParse(Input, out result) && condition(result))
                {
                    vehicleParameter = result;
                    valid = true;
                }
                else
                {
                    UI.PrintData($"{VehicleInputRules}");
                }
            }
        }

        public static void SetStringmember(string vehicleParameter, string VehicleInputRules, Func<string,bool> condition)
        {
            ConsoleUI.PrintData($" Enter {vehicleParameter}:");
            var Input = UI.UserInput();
            if (condition(Input))
            {
                vehicleParameter = UI.UserInput();
            }
            else
            {
                ConsoleUI.PrintData($"{VehicleInputRules}");
            }

        }

        //public static void Input<T>(object[] parameters[], Action<string> output, Func<T,T,bool> parse, Func<string> input, object[] VehicleInputRules)//
        //{
        //        var valid = false;
        //        //var Input;
        //        int index = 0;
        //        var Parseout;
        //    foreach ( var item in parameters)
        //    {
        //            index++; 

        //        output($" Enter the vehicles {item}:");
        //            while (valid == false)
        //            {
        //            var Input = input();
        //            Input.parse(valid, Parseout);
        //                if (valid == true)
        //                {
        //                    parameters[index] = Parseout;
        //                }
        //                else
        //                {
        //                    output($"{VehicleInputRules[index]}");
        //                }

        //            }
        //    }
        //}

    }


}
