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
            Menu(garageHandler);
            //Show main meny

            //Act
            ParkVehicle();

        }

        // See to the structure of menu and return. 
        private void Menu(GarageHandler garagehandler)
        {
            UserMenu userMenu = new UserMenu();
            bool quit = false;
            while (quit == false)
            {
                (quit,garagehandler) = userMenu.Start(garagehandler);
            }
        }

        private void ParkVehicle()
        {
           // This is the next thing to address
           var car = garageHandler.CreateCar();
           garageHandler.Park(car);
        }

       
    }
}