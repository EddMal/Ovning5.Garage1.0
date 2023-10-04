﻿using System;
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

        public static void SetInt( int internalproperty, string InputRules, Func<int, bool> condition)
        {
            UI.PrintData($"{InputRules}");
            bool valid = false;
            while (valid == false)
            {
                string Input = UI.UserInput();
                int result;
                if (int.TryParse(Input, out result) && condition(result))
                {
                    internalproperty = result;
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
            int vehicleParameter = 0;//Quickfix?
            UI.PrintData($"{InputRules}");
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
                    UI.PrintData($"{InputRules}");
                }
            }
            return vehicleParameter;
        }

        public static void SetString(string internalproperty, string InputRules, Func<string,bool> condition)
        {
            ConsoleUI.PrintData($" Enter {InputRules}:");
            var Input = UI.UserInput();
            if (condition(Input))
            {
                //?? Change to Input ??
                internalproperty = UI.UserInput();
            }
            else
            {
                ConsoleUI.PrintData($"{InputRules}");
            }

        }

        public static void SetChar(char internalproperty, string InputRules, Func<string, bool> condition)
        {
            ConsoleUI.PrintData($" Enter {InputRules}:");
            var Input = UI.UserInput();
            if (condition(Input))
            {
                internalproperty = Input[0];
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