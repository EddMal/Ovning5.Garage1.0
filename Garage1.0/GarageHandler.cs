using static Garage1._0.VehicleProperties;
using static Garage1._0.VehicleSubclasses;
using static Garage1._0.VehicleSubclasses.Airplane;

namespace Garage1._0
{
    internal class GarageHandler:VehicleProperties
    {
        private Garage<Vehicle> garage;
        

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            UI.PrintData($"New garage created with the capacaty of {capacity} slots.");
        }

        internal void Park(Vehicle v)
        {
            garage.Park(v);
        }

        internal virtual Vehicle CreateVehicle(int action)
        {
            //VehicleProperties vehicleProperties = new VehicleProperties();
            ////Validated validated = new Validated();
            //Validated.SetString(vehicleProperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //Validated.SetString(vehicleProperties.Color, $"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s);});
            //Validated.SetString(vehicleProperties.RegistrationNumber, $"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return true ? s.Length < 20 : false; });
            ////Validated.SetInt(Vehicleproperties.NumberOfWheels, "Enter the vehicles number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });
            Vehicle createdVehicle;
            switch (action)
            {
                case 0:// "AIRPLANE":

                    break;
                case 1:// "BOAT":

                    break;
                case 2:// "BUS":

                    break;
                case 3://"CAR":
                    createdVehicle = CreateCar();
                    break;
                case 4:// "MOTORCYCLE":

                    break;
                default:
                    ConsoleUI.PrintData($"Faulty input \"{action}\".");
                    break;
            }
                    return createdVehicle;
        }
        public virtual Car CreateCar()
        {
            
            VehicleProperties vehicleProperties = new VehicleProperties();
            //Validated validated = new Validated();
            vehicleProperties.Type = "car";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive($"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString( $"Valid length for registration number is 6 to 20 {Type}:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt( "Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.NumberOfSeats = Validated.SetInt( "Enter the number of seats. Input Must be entered in numbers and be less than 50", (seats) => { return true ? seats < 10 && seats > 0: false; });
            Car car = new Car(vehicleProperties);

            return car;
        }

        public virtual Airplane CreateAirplane()
        {

            VehicleProperties vehicleProperties = new VehicleProperties();
            //Validated validated = new Validated();
            vehicleProperties.Type = "car";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive($"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString($"Valid length for registration number is 6 to 20 {Type}:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 50", (seats) => { return true ? seats < 10 && seats > 0 : false; });
            Airplane CreateAirplane = new Airplane(vehicleProperties);

            return car;
        }

    }
}