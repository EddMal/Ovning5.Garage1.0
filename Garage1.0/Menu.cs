using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Garage1._0.VehicleProperties;

namespace Garage1._0
{
    abstract class ExamineInputMenu
    {
        //Could be replaced with locals inside methods.
        private string input;
        private char selectAction;


        public string Input
        {
            get
            {
                return input;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException($"Error: Faulty input: \"{value}\", input must be at least 1 character");
                }

                input = value;

            }
        }

        public char SelectAction
        {
            get
            {
                return selectAction;
            }
            set
            {
                if (value is ' ')//value is '-' or '+')
                {
                    throw new ArgumentException($"Error: Faulty input: \"{value}\", input must consist of a character.");
                }

                selectAction = value;

            }

        }


        //Method should be divided in to methods for readability and "changeability", and a lot of the content would be beneficial to move to ExamineInput".
        public virtual Garage<Vehicle> Menu(Garage<Vehicle> garage)
        {
            //Validated validated = new Validated();
            Garage<Vehicle> garageInput = garage;
            UI.PrintData("Welcome to manage your garage!\n Enter \"q\" to close the application.\n\"1\" to park a car.\n\"2\" to remove a car from garage.\n\"3\"to search for vehicle");
            do
            {
                UI.PrintData("Enter \"q\" to close the application.\n\"1\" to park a car.\n\"2\" to remove a car from garage.\n\"3\"to view list of vehicles with properties based search.");

                Validated.SetChar(SelectAction, "Select action:", (string s) => { return true ? s.Length == 1 : false; });

                switch (SelectAction)
                {
                    case '1':
                        //Move to method.
                        
                        string vehicle = Validated.SetString("Select action:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); } ) ;
                        //GarageHandler.CreateVehicle(vehicle);
                        //garageInput.Add(Input);
                        UI.PrintData($"Added \"{Input}\" to the Garage.");
                        break;
                    case '2':
                        bool inputFound = false;

                        //foreach (var item in garageInput)
                        //{
                        //    //Removes one item of input-name, if there are more members with the same name they will remain on the list.
                        //    if (Input == item)
                        //    {
                        //        garageInput.Remove(Input);
                        //        inputFound = true;
                        //        UI.PrintData($"Removed \"{Input}\" from the list.");
                        //        break;
                        //    }
                        //}
                        if (!inputFound)
                        {
                            UI.PrintData($"{Input} does not exist in the garage.:");
                        }
                        break;
                    case '3':
                        //bool inputFound = false;

                        //foreach (var item in garageInput)
                        //{
                        //    //Removes one item of input-name, if there are more members with the same name they will remain on the list.
                        //    if (Input == item)
                        //    {
                        //        garageInput.Remove(Input);
                        //        inputFound = true;
                        //        UI.PrintData($"Removed \"{Input}\" from the list.");
                        //        break;
                        //    }
                        //}
                        //if (!inputFound)
                        {
                            UI.PrintData($"No vehicle with macthing properties was found in the garage.\nProperties:");
                            //LOOP properties of vehicles
                            //{
                            ///UI.PrintData($" The \"{properties[i]}\");
                            //}
                            ///UI.PrintData($" does not exist in the list.");
                        }
                        break;
                    case '4':
                        //bool inputFound = false;

                        //foreach (var item in garageInput)
                        //{                           
                        //    if (Input == item.RegistrationNumber)
                        //    {
                                
                        //        inputFound = true;
                        //        UI.PrintData($"{item} with registration number \"{Input}\" is parked on slot {item.slot}");
                        //        break;
                        //    }
                        //}
                        //if (!inputFound)
                        {
                            UI.PrintData($"{Input} does not exist in the garage.:");
                        }
                        break;
                    case 'q':
                        break;
                    default:
                        UI.PrintData($"Faulty input.");
                        break;

                }



            } while (SelectAction != 'q');

            return garageInput;
        }
    } 
}

