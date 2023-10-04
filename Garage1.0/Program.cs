namespace Garage1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            manager.Run();

            int NumberOfWheels=0;
            Validated.SetInt(NumberOfWheels, "Enter number of wheels for vehicle. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });
            
        }
    }
}