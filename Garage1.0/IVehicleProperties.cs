namespace Garage1._0
{
    internal interface IVehicleProperties
    {
        string Color { get; }
        int NumberOfWheels { get; }
        string RegistrationNumber { get; }
        string Type { get; }
        object[] vehicleProperties { get; }
    }
}