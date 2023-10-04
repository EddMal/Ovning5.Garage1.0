namespace Garage1._0
{
    internal class GarageHandler
    {
        private Garage<IVehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<IVehicle>(capacity);
            UI.PrintData($"New garage created with the capacaty of {capacity} slots.");
        }

        internal void Park(IVehicle v)
        {
            garage.Park(v);
        }

        public virtual VehicleProperties CreateVehicle()
        {
            VehicleProperties Vehicleproperties = new VehicleProperties();
            //Validate.SetString(Color, "Must be entered in numbers and be less than 50", (valid) => { return true ? valid < 50 : false; });
            //color = Color;
            //type = Type;
            //registrationNumber = RegistrationNumber;
            Validated.SetInt(Vehicleproperties.NumberOfWheels, "Enter the vehicles number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });


            return Vehicleproperties;


        }
    }
}