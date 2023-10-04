using System.ComponentModel.Design;

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
            //Ask if the user wish to populate the crage with a couple of vehicles:
        }

        internal void Run()
        {
            //Ask for capacity
            Menu();
            //Show main meny

            //Act
            ParkVehicle();

        }

        private void Menu()
        {
            throw new NotImplementedException();
        }

        private void ParkVehicle()
        {
           var v  = new Car(new VehicleProperties());
            garageHandler.Park(v);
        }
    }
}