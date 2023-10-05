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
    internal class Validated
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

        public static void SetInt( int instanceProperty, string InputRules, Func<int, bool> condition)
        {
            UI.PrintData($"{InputRules}");
            bool valid = false;
            while (valid == false)
            {
                string Input = UI.UserInput();
                int result;
                if (int.TryParse(Input, out result) && condition(result))
                {
                    instanceProperty = result;
                    valid = true;
                }
                else
                {
                    UI.PrintData($"{InputRules}");
                }
            }
        }

        public static int SetInt(string InputRules, Func<int, bool> condition)
        {
            int intOut = 0;//Quickfix?
            UI.PrintData($"{InputRules}");
            bool valid = false;
            while (valid == false)
            {
                string Input = UI.UserInput();
                int result;
                if (int.TryParse(Input, out result) && condition(result))
                {
                    intOut = result;
                    valid = true;
                }
                else
                {
                    UI.PrintData($"{InputRules}");
                }
            }
            return intOut;
        }

        //Note to selfe 1.1 this should manipulate property, it did not.. possible reason a instance of car did not exist and ! thereby property? 
        public static void SetString(string instanceProperty, string InputRules, Func<string, bool> condition)
        {
            ConsoleUI.PrintData($" Enter {InputRules}:");
            bool valid = false;
            while (valid == false)
            {
                var Input = UI.UserInput();
                if (condition(Input))
                {
                    instanceProperty = Input;
                    valid = true;
                }
                else
                {
                    ConsoleUI.PrintData($"{InputRules}");
                }
            }

        }

        public static string SetString(string InputRules, Func<string, bool> condition)
        {
            string result = " ";//Quick fix resolve
            ConsoleUI.PrintData($" Enter {InputRules}:");
            bool valid = false;
            while (valid == false)
            {
                var Input = UI.UserInput();
                if (condition(Input))
                {
                    result = Input;
                    valid = true;
                }
                else
                {
                    ConsoleUI.PrintData($"{InputRules}");
                }
            }
            return result;

        }

        public static string SetStringCaseInsesitive(string InputRules, Func<string, bool> condition)
        {
            ConsoleUI.PrintData($" Enter {InputRules}:");
            bool valid = false;
            var Input = "Missing";//quick fix?
            while (valid == false)
            {
                Input = UI.UserInput();
                var Input2 = Input.ToUpper();
                if (condition(Input2))
                {
                    valid = true;
                }
                else
                {
                    ConsoleUI.PrintData($"{InputRules}");
                }
            }
            return Input;

        }

    

        public static void SetChar(char instanceProperty, string InputRules, Func<string, bool> condition)
        {
            ConsoleUI.PrintData($" Enter {InputRules}:");
            var Input = UI.UserInput();
            if (condition(Input))
            {
                instanceProperty = Input[0];
            }
            else
            {
                ConsoleUI.PrintData($"{InputRules}");
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
