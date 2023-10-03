namespace Garage1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfWheels=0;
            Validate.SetIntmember(NumberOfWheels, "Enter number of wheels for vehicle. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });
            
        }
    }
}