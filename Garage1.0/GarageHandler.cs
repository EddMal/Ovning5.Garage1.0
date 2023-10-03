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
    }
}