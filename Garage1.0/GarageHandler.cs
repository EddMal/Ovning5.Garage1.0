using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using static Garage1._0.VehicleProperties;
//using static Garage1._0.VehicleProperties;
using static Garage1._0.VehicleSubclasses;
using static Garage1._0.VehicleSubclasses.Airplane;

namespace Garage1._0
{
    internal class GarageHandler : VehicleProperties
    {
        private Garage<Vehicle> garage;

        protected string[] registrationNumbers;
        protected int count;


        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            registrationNumbers = new string[capacity];
            UI.PrintData($"New garage created with the capacaty of {capacity} slots.");

            string pouplate = Validated.SetStringCaseInsesitive("If you want to populate garage from start: enter yes or no:\n", (string s) => { return true ? s == "YES" || s == "NO" : false; });
            if (pouplate.ToUpper() == "YES")
            {
                PopulateGarageCars();
            }
        }

        internal void Park(Vehicle v)
        {
            count = garage.Park(v);
        }

        internal bool Remove(string registrationNumber)
        {
            bool vehicleRemoved = false;
            vehicleRemoved = garage.Remove(registrationNumber);
            return vehicleRemoved;
        }

        internal (bool, object[][], int[]) SearchMatchingProperty(string vehicleProperty, Func<string, bool> condition)
        {
            var matchFound = false;
            object[][] matchingVehicles;
            int[] matchingVehiclesID;
            (matchFound, matchingVehicles, matchingVehiclesID) = garage.SearchMatchingProperty(vehicleProperty, condition);
            return (matchFound, matchingVehicles, matchingVehiclesID);
        }

        internal (bool, object[][]) SearchMatchingProperty(object[] vehicleProperties)
        {
            var matchFound = false;
            object[][] matchingVehicles;
            object[][] matchingVehiclestemp;
            matchingVehiclestemp = new object[count][];

            int[] matchingVehiclesIDtemp;
            matchingVehiclesIDtemp = new int[count];
            int[] matchingVehiclesID;
            matchingVehiclesID = new int[count];

            int validvehicle = 0;

            while (vehicleProperties[validvehicle] == null)
            {
                validvehicle++;
            } 
            
            
            if (vehicleProperties[validvehicle] != null)
            {
                // matching ID redudant create overload.
                (matchFound, matchingVehiclestemp, matchingVehiclesIDtemp) = garage.SearchMatchingProperty(vehicleProperties[validvehicle].ToString(), (s) => true ? s == vehicleProperties[validvehicle].ToString().ToUpper() : false);
            }

            (matchFound,matchingVehicles) = CompareVehicles(matchingVehiclestemp, vehicleProperties);
           

            return (matchFound, matchingVehicles);

        }

        internal (bool, object[][]) CompareVehicles(object[][] matchingVehiclestemp, object[] vehicleProperties)
        {
            object[][] matchingVehicles;
            //Handel better:
            matchingVehicles = new object[matchingVehiclestemp.Length][];

            
            int countindex = 0;
            bool matchFound= false;

            if (matchingVehiclestemp != null)
            {
                foreach (var vehicle in matchingVehiclestemp)
                {
                    
                    if (vehicle != null)
                    {
                        //Address use of object "vehicleProperties" change garageproperties object[] to ensure movable code.
                        for (int i = 0; i < vehicle.Length; i++)
                        {
                            string[] stringtempvehicles = Array.ConvertAll(matchingVehiclestemp[i], x => x.ToString());
                            string[] stringtempproperties = Array.ConvertAll(matchingVehiclestemp[i], x => x.ToString());
                            for (int i2 = 0; i2 < vehicleProperties.Length; i2++)
                            {
                                matchFound = false;
                                if (vehicle[i] != null || vehicleProperties[i2] != null)
                                {
                                    
                                    if (vehicleprop != null || searcproperty != null)
                                    if (vehicleprop.ToUpper() == searcproperty.ToUpper())
                                    {
                                        matchFound = true;
                                    }
                                }
                            }
                        }

                    }
                    if (matchFound == true)
                    {
                        matchingVehicles.Append(matchingVehiclestemp);

                    }
                    countindex++;
                }
            }
            if (matchingVehicles == null)
            {
                matchFound = false;
            }
            else
            {
                matchFound = true;
            }

            return (matchFound, matchingVehicles);
        }

        public virtual (bool, VehicleProperties) ReadVihecleProperties(Vehicle vehicle)
        {
            VehicleProperties thisVehicle = new VehicleProperties();
            var matchFound = false;
            string vehicleType = vehicle.vehicleProperties[0].ToString();
            vehicleType.ToUpper();
            //while (matchFound==false)
            //{
            if (Enum.IsDefined(enumType: typeof(VehicleType), value: vehicleType) == true)
            {
                matchFound = true;
              
                thisVehicle.vehicleProperties = SpecifiedVihecleProperties(vehicleType);
                //The assigning below should be switched to straight use of vehicleProperties "Type" etc :
                thisVehicle.Type = (string)vehicle.vehicleProperties[0];
                thisVehicle.Color = (string)vehicle.vehicleProperties[1];
                thisVehicle.RegistrationNumber = (string)vehicle.vehicleProperties[2];
                thisVehicle.NumberOfWheels = (int)vehicle.vehicleProperties[3];

                if (vehicleType == "AIRPLANE")
                {
                    NumberOfSeats = (int)vehicle.vehicleProperties[4];
                }
                else if (vehicleType == "BUS")
                {
                    thisVehicle.ElectricMotor = (string)vehicle.vehicleProperties[4];
                }
                else if (vehicleType == "BOAT")
                {
                    thisVehicle.Decks = (int)vehicle.vehicleProperties[4];
                }
                else if (vehicleType == "CAR")
                {
                    thisVehicle.CarBrand = (string)vehicle.vehicleProperties[4];
                }
                else if (vehicleType == "MOTORCYCLE")
                {
                    thisVehicle.Roof = (string)vehicle.vehicleProperties[4];
                }
                else { };

            }

            return (matchFound, thisVehicle);

            //}
        }
        ////Overload develop..
        //internal static (bool,VehicleProperties) DecodeVihecleProperties(object[] vihecle, string property)
        //{
        //    VehicleProperties thisVehicle = new VehicleProperties();
        //    var matchFound = false;
        //    property.ToUpper();
        //    //while (matchFound==false)
        //    //{
        //        if (Enum.IsDefined(enumType: typeof(VehicleType), value: property) == true)
        //        {
        //            matchFound = true;
        //        //return (matchFound, $"{property}");
        //         thisVehicle.vehicleProperties = SpecifiedVihecleProperties(property);
        //        }

        //        return (matchFound, thisVehicle);
               
        //    //}
        //}

        //internal (IEnumerable<Vehicle>, bool) SearchMatchingProperties(string vehicleProperty, Func<string, bool> condition)
        //{
        //    var matchFound = false;
        //    IEnumerable<Vehicle> matchingVehicles;
        //    (matchingVehicles, matchFound) = garage.SearchMatchingProperty(vehicleProperty, condition);
        //    return (matchingVehicles, matchFound);
        //}

        internal List<Vehicle> GetAllGarageData()
        {

            List<Vehicle> vehicles = (List<Vehicle>)garage.GetEnumerator();
            return vehicles;
        }

        internal virtual Vehicle CreateVehicle(int action)
        {
            Vehicle createdVehicle;
            switch (action)
            {
                case 0:// "AIRPLANE":
                    createdVehicle = CreateAirplane();
                    break;
                case 1:// "BOAT":
                    createdVehicle = CreateBoat();
                    break;
                case 2:// "BUS":
                    createdVehicle = CreateBus();
                    break;
                case 3://"CAR":
                    createdVehicle = CreateCar();
                    break;
                case 4:// "MOTORCYCLE":
                    createdVehicle = CreateMotorcycle();
                    break;
                default:
                    throw new ArgumentException("Something went wrong when trying to create a vehicle, probably caused by the handling of input.");
                    //break;
            }
                    return createdVehicle;
        }

        internal virtual bool  RegistrationNumberControl(string registrationNumber)
        {
            
            bool validRegNr = true;
            string regNr = "\nRegistration number verified.";
            foreach (var registrationNr in registrationNumbers) 
            {
                if (registrationNr != null || registrationNr == "")
                {
                    if (registrationNr.ToUpper() == registrationNumber)
                    { 
                        validRegNr = false;
                        regNr = "\nRegistration number is not unique.";
                        break;
                    }
                    else
                    {
                        registrationNumbers[count] = registrationNumber;
                        break;
                    }
                }
                else
                {
                    registrationNumbers[count] = registrationNumber;
                    break;
                }
            }
            //Consider a better solution for handling of the printing of messages:
            UI.PrintData($"{regNr}");
            return validRegNr;
        }

        public virtual Airplane CreateAirplane()
        {

            //VehicleProperties airplaneProperties = new VehicleProperties();
            //Validated validated = new Validated();

            //airplaneProperties.Type = "Airplane";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //airplaneProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            //airplaneProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            //airplaneProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            //airplaneProperties.NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 25", (seats) => { return true ? seats <= 25 && seats >= 0 : false; });

            //If VehicleProperties use is unwanted the parameters for Color etcetera can be replaced with local var.
            Type = "Airplane";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            RegistrationNumber = Validated.SetStringCaseInsesitive("Enter a unique registration number with valid length(span:6 to 20):", (string s) => { return true ? (s.Length < 20 && s.Length > 5) && (RegistrationNumberControl(s)) : false; });
            NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 25", (seats) => { return true ? seats <= 25 && seats >= 0 : false; });

            object[] airplaneProperties = new object[] { Type, Color, RegistrationNumber, NumberOfWheels, NumberOfSeats };

            Airplane airplane = new Airplane(airplaneProperties);

            return airplane;
        }

        public virtual Boat CreateBoat()
        {

            //VehicleProperties boatProperties = new VehicleProperties();
            //boatProperties.Type = "Boat";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //boatProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the airplane:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            //boatProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            //boatProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            //boatProperties.Decks = Validated.SetInt("Enter the number of decks. Input Must be entered in numbers and must be within range 0 to 2", (decks) => { return true ? decks < 0 && decks > 2 : false; });

            Type = "Boat";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the airplane:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            RegistrationNumber = Validated.SetStringCaseInsesitive("Enter a unique registration number with valid length(span:6 to 20):", (string s) => { return true ? (s.Length < 20 && s.Length > 5) && (RegistrationNumberControl(s)) : false; });
            NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            Decks = Validated.SetInt("Enter the number of decks. Input Must be entered in numbers and must be within range 0 to 2", (decks) => { return true ? decks < 0 && decks > 2 : false; });


            object[] boatProperties = new object[] { Type, Color, RegistrationNumber, NumberOfWheels, Decks };


            Boat boat = new Boat(boatProperties);

            return boat;
        }

        public virtual Bus CreateBus()
        {

           // VehicleProperties busProperties = new VehicleProperties();

            //busProperties.Type = "Bus";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //busProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the bus:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            //busProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            //busProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            //busProperties.ElectricMotor = Validated.SetStringCaseInsesitive("The bus must have an electric motor:", (string s) => { return true ? s == "YES" || s == "NO" : false; });

            Type = "Bus";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the bus:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            RegistrationNumber = Validated.SetStringCaseInsesitive("Enter a unique registration number with valid length(span:6 to 20):", (string s) => { return true ? (s.Length < 20 && s.Length > 5) && (RegistrationNumberControl(s)) : false; });
            NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            ElectricMotor = Validated.SetStringCaseInsesitive("Does the bus have an electric motor answer (yes or no):", (string s) => { return true ? s == "YES" || s == "NO" : false; });


            object[] busProperties = new object[] { Type, Color, RegistrationNumber, NumberOfWheels, ElectricMotor };
            Bus bus = new Bus(busProperties);

            return bus;
        }

        public virtual Car CreateCar()
        {
            
           // new object[] carProperties = new VehicleProperties();

             Type = "car";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
             Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
             RegistrationNumber = Validated.SetStringCaseInsesitive("Enter a unique registration number with valid length(span:6 to 20):", (string s) => { return true ? (s.Length < 20 && s.Length > 5) && (RegistrationNumberControl(s)) : false; });
             NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
             CarBrand = Validated.SetStringCaseInsesitive("Valid brands are: \nVolvo,\nSaab,\nFiat,\nToyota,\nNissan,\nRenault\nFord,\nAudi\nVolkswagen,\nIf the brand is not represented enter other\nEnter the brand of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(CarBrands), value: s); });

            object[] carProperties = new object[] { Type, Color, RegistrationNumber, NumberOfWheels, CarBrand };
            Car car = new Car(carProperties);

            return car;
        }

        public virtual void PopulateGarageCars()
        {


            object[][] initiate = GarageProperties.PopulateGarage();
            
            var vehicleType = "car";

            for (int i = 0; i < 6; i++)
            {
                object[] carProperties = new object[] { vehicleType, initiate[i][0], initiate[i][1], initiate[i][2], initiate[i][3] };
                Car car = new Car(carProperties);
                Park(car);
            }
            UI.PrintData($"Populated garage with {this.count} {vehicleType}");
        }

        public virtual Motorcycle CreateMotorcycle()
        {

            //VehicleProperties motorcycleProperties = new VehicleProperties();

            Type = "Motorcycle";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            RegistrationNumber = Validated.SetStringCaseInsesitive("Enter a unique registration number with valid length(span:6 to 20):", (string s) => { return true ? (s.Length < 20 && s.Length > 5) && (RegistrationNumberControl(s)) : false; });
            NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            Roof = Validated.SetStringCaseInsesitive("The information about wheter the motorcycle has a roof is mandatory Enter yes or no:", (string s) => { return true ? s == "YES" || s == "NO" : false; });

            object[] motorcycleProperties = new object[] { Type, Color, RegistrationNumber, NumberOfWheels, Roof };


            Motorcycle motorcycle = new Motorcycle(motorcycleProperties);

            return motorcycle;
        }

        public virtual object[] CreateUndefinedVehicle()
        {
            //Really bad long method and not at all optimized code, makes the angles cry(and me), change.

            // new object[] carProperties = new VehicleProperties();
            object[] undefinedVehicleProperties = new object[5];
            int countObjects = 0;
            Type = Validated.SetStringCaseInsesitive("Enter search parameters, proceed to next search parameter without making input by pressing q.\nType of the vehicle valid types are \"Airplane, Boat, Bus, Car, and motorcycle\"\n:", (string s) => { return true ? Enum.IsDefined(enumType: typeof(VehicleType) , value: s) || s == "Q" : false; });
            //Nasty code if cases and countObjexts should be optimized.
            if (Type.ToUpper() != "Q")
            {
                undefinedVehicleProperties[countObjects] = Type;
                
            }
            countObjects++;
            Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car or q to proceed to next search parameter:\n", (string s) => { return true ? Enum.IsDefined(enumType: typeof(VehicleColor), value: s) || s == "Q":false; });
            if (Color.ToUpper() != "Q")
            {
                undefinedVehicleProperties[countObjects] = Color;
            }
            countObjects++;
            RegistrationNumber = Validated.SetStringCaseInsesitive("Enter registration number with valid length(span:6 to 20) or q to proceed to next input parameter:\n", (string s) => { return true ? ((s.Length < 20 && s.Length > 5) && (RegistrationNumberControl(s))) || s == "Q" : false; });
            if (RegistrationNumber.ToUpper() != "Q")
            {
                undefinedVehicleProperties[countObjects] = RegistrationNumber;
            }
            countObjects++;
            var NumberWheels = Validated.SetStringCaseInsesitive("Enter the number of wheels or q to proceed to next input parameter.\n", (wheels) => { return true ? (wheels != "" || wheels == "Q" ): false; });
            if (NumberWheels.ToUpper() != "Q")
            {
                undefinedVehicleProperties[countObjects] = NumberWheels;
            }
            countObjects++;
            string select = Validated.SetStringCaseInsesitive("\nIf you know the type of the vehicle, you can use searchoptions for their special properties.\n Enter 0 Airplane, 1 Boat, 2 Bus, 3 Car, 4 Motorcycle, q to proceed without input\n:", (string s) => { return true ? s == "0" || s == "1" || s == "2" || s == "3" || s == "4" || s == "Q" : false; });

            var NumberSeats ="";
            switch (select.ToUpper())
            {
                case "0":// "AIRPLANE":
                    NumberSeats = Validated.SetStringCaseInsesitive("Enter the number of seats", (seats) => { return true ? (seats != "" || seats == "Q") : false; });
                    if (NumberSeats.ToUpper() != "Q")
                    {
                        undefinedVehicleProperties[countObjects] = NumberSeats;
                        countObjects++;
                    }
                    break;
                case "1":// "BOAT":
                    var Deck = Validated.SetStringCaseInsesitive("Enter the number of decks", (decks) => { return true ? decks != "" || decks == "Q" : false; });
                    if (Deck.ToUpper() != "Q")
                    {
                        undefinedVehicleProperties[countObjects] = Deck;
                        countObjects++;
                    }
                    break;
                case "2":// "BUS":
                    ElectricMotor = Validated.SetStringCaseInsesitive("Does the bus have an electric motor:", (string s) => { return true ? s == "YES" || s == "NO" || s == "Q" : false; });
                    if (ElectricMotor.ToUpper() != "Q")
                    {
                        undefinedVehicleProperties[countObjects] = ElectricMotor;
                        countObjects++;
                    }
                    break;
                case "3"://"CAR":
                    CarBrand = Validated.SetStringCaseInsesitive("Valid brands are: \nVolvo,\nSaab,\nFiat,\nToyota,\nNissan,\nRenault\nFord,\nAudi\nVolkswagen,\nIf the brand is not represented enter other\nEnter the brand of the car:", (string s) => { return true ? Enum.IsDefined(enumType: typeof(CarBrands), value: s) || s == "Q":false; });
                    if (CarBrand.ToUpper() != "Q")
                    {
                        undefinedVehicleProperties[countObjects] = CarBrand;
                        countObjects++;
                    }
                    break;
                case "4":// "MOTORCYCLE":
                    Roof = Validated.SetStringCaseInsesitive("The information about wheter the motorcycle has a roof is mandatory Enter yes or no:", (string s) => { return true ? s == "YES" || s == "NO" || s == "Q" : false; });
                    if (Roof.ToUpper() != "Q")
                    {
                        undefinedVehicleProperties[countObjects] = Roof;
                        countObjects++;
                    }
                    break;
                case "Q":
                    break;
                default:
                    break;
            }
            
                    
            //UndefinedVehicle undefinedVehicle = new UndefinedVehicle(undefinedVehicleProperties);

            return undefinedVehicleProperties;
        }





    }
}