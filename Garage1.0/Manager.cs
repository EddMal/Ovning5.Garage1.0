namespace Garage1._0
{
    internal class Manager
    {
        private Handler handler;

        public Manager()
        {
            //Take capacity from user!
            handler  = new Handler(10);
        }

        internal void Run()
        {
            //Ask for capacity

            //Show main meny

            //Act
            ParkVehicle();

        }

        private void ParkVehicle()
        {
           var v  = new Car(new VehicleAttribute());
            handler.Park(v);
        }
    }
}