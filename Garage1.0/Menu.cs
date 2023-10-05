using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Garage1._0.VehicleProperties;

namespace Garage1._0
{
     class UserMenu
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
        public virtual (bool, GarageHandler) Start(GarageHandler garageHandler)
        {
            //
            GarageHandler garageInput = garageHandler;

            do
            {
                Vehicle vehicle;
                vehicle.Type = "Unknown vehicle";
                UI.PrintData("Instructions to manage the garage:\n Enter \"q\" to close the application.\n\"0\" to create a vehicle.\n\"1\" to park a vehicle.\n\"2\" to remove a vehicle from garage.\n\"3\"to search for vehicle");

                Validated.SetChar(SelectAction, "Select action:", (string s) => { return true ? s.Length == 1 : false; });

                switch (SelectAction)
                {
                    case '0': // Add a vehicle
                        //Move to method.
                        UI.PrintData("Create a vehicle:\n Enter \"q\" to exit to main menu.\n\"0\" to add a Airplane.\n\"1\" to add a boat.\n\"2\" to add a Bus\n\"3\"to add a car\n\"4\"to add a motorcycle");
                        int Action = Validated.SetInt("Select action:", (int s) => { return true ? s>=0 && s <= 4 : false; });
                        vehicle = garageInput.CreateVehicle(SelectAction);
                        //garageInput.Add(Input);
                        UI.PrintData($"Created a new \"{vehicle.Type}\"");
                        break;
                    case '1': // Park a vehicle
                        //Move to method.
                        if (vehicle.Type == "Unknown vehicle")
                        {
                            ConsoleUI.PrintData($"There is no vehicle to park, start with creating a new vehicle(option 0).");
                        }
                        else
                        {
                            garageInput.Park(vehicle);
                            UI.PrintData($"Added \"{vehicle.Type}\" to the Garage.");
                            vehicle.Type = "Unknown vehicle";
                        }
                        break;
                    case '2': // Remove a vehicle.
                        bool inputFound = false;

                        foreach (var item in garageInput)
                        {
                            //Removes one item of input-name, if there are more members with the same name they will remain on the list.
                            if (Input == item)
                            {
                                garageInput.Remove(Input);
                                inputFound = true;
                                UI.PrintData($"Removed \"{Input}\" from the list.");
                                break;
                            }
                        }
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

            return (true,garageInput);
        }
    } 
}

