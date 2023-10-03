namespace Garage1._0
{
    internal class GarageHandler
    {
        private Garage<IVehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<IVehicle>(capacity);
        }

        internal void Park(IVehicle v)
        {
            garage.Park(v);
        }
    }
}