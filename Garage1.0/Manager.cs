namespace Garage1._0
{
    internal class Manager
    {
        private GarageHandler garageHandler;
        
        
        public Manager()
        {
            //Take capacity from user!
            int capacity = GarageProperties.SetCapacity();
            garageHandler  = new GarageHandler(capacity);
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
            garageHandler.Park(v);
        }
    }
}