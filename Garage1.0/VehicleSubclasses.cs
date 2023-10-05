using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class VehicleSubclasses
    {

        public class Airplane : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Airplane(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
            public class Car : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Car(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {
                
            }



                //public virtual VehicleProperties CreateVehicle(VehicleType vehicle)
                //{
                //    VehicleProperties Vehicleproperties = new VehicleProperties();
                //    Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
                //    Validated.SetString(Vehicleproperties.Color, $"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
                //    Validated.SetString(Vehicleproperties.RegistrationNumber, $"Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the {Type}:", (string s) => { return true ? s.Length < 20 : false; });
                //    Validated.SetInt(Vehicleproperties.NumberOfWheels, "Enter the vehicles number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });

                //    return Vehicleproperties;
                //}

            }
    }
}
