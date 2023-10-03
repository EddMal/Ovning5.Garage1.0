namespace Garage1._0
{
    internal class Handler
    {
        private Garage<IVehicle> garage;

        public Handler(int capacity)
        {
            garage = new Garage<IVehicle>(capacity);
        }

        internal void Park(IVehicle v)
        {
            garage.Park(v);
        }
    }
}