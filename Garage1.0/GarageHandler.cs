using static Garage1._0.VehicleProperties;

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

        public virtual VehicleProperties CreateVehicle(VehicleType vehicle)
        {   
            VehicleProperties vehicleProperties = new VehicleProperties();
            //Validated validated = new Validated();
            Validated.SetString(vehicleProperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            Validated.SetString(vehicleProperties.Color, $"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s);});
            Validated.SetString(vehicleProperties.RegistrationNumber, $"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return true ? s.Length < 20 : false; });
            //Validated.SetInt(Vehicleproperties.NumberOfWheels, "Enter the vehicles number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });

            return vehicleProperties;
        }
        public virtual VehicleProperties CreateCar()
        {
            VehicleProperties vehicleProperties = new VehicleProperties();
            //Validated validated = new Validated();
            vehicleProperties.Type = "car";//Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive($"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            Validated.SetString(RegistrationNumber, $"Valid length for registration number is 6 to 20 {Type}:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            Validated.SetInt(NumberOfWheels, "Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });
            Validated.SetInt(NumberOfSeats, "Enter the number of seats. Input Must be entered in numbers and be less than 50", (seats) => { return true ? seats < 10 : false; });
            

            return vehicleProperties;
        }

        
    }
}