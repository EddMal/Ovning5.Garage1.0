using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal abstract class Vehicle : VehicleProperties//, IVehicle
    {
        //private string color;
        //private string type;
        //private string registrationNumber;
        //private int numberOfWheels;


        //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels };

        // VehicleProperties vehicleProperties { get; set; }
        public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels };

        //public Vehicle(VehicleProperties vehicleProperties)
        //{
        //    this.vehicleProperties = vehicleProperties;
        //}


        // Is this not used yet? if not remove.
        //public Vehicle(string color, string registrationNumber, int numberOfWheels, int numberOfSeats)
        //{
        //    var vehicleProps = new VehicleProperties() { Color = color,
        //                                                 Type = "Unknown vehicle",
        //                                                 RegistrationNumber = registrationNumber,
        //                                                 NumberOfWheels = numberOfWheels,
        //                                                 NumberOfSeats = numberOfSeats
        //    };
        //}

        public Vehicle(object[] vehicleProperties)//string color, string registrationNumber, int numberOfWheels, int numberOfSeats)
        {

            this.vehicleProperties = vehicleProperties;
        }

        
        //public Vehicle(string color, string type, string registrationNumber, int numberOfWheels)//, int numberOfSeats)
        //{
        //    var vehicleAttribute = new VehicleProperties()
        //    {
        //        Color = color,
        //        Type = type,
        //        RegistrationNumber = registrationNumber,
        //        NumberOfWheels = numberOfWheels,
        //        //NumberOfSeats = numberOfSeats
        //    };
        //}



        //public string Color 
        //{
        //    get { return color; }
        //    // Protected only sub-classes can set;
        //    protected set 
        //    {

        //    }
        //}
        //public string Type 
        //{
        //    get => type;
        //    protected set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException("Type of vehicle cant be left empty");
        //        }
        //        type = value;
        //    }
        //}

        //public string RegistrationNumber
        //{
        //    get => registrationNumber;

        //    protected set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException("Registration number cant be left empty");
        //        }

        //        registrationNumber = value;
        //    }
        //}

        //public int NumberOfWheels 
        //{
        //    get => numberOfWheels;
        //    protected set
        //    {
        //        if (value < 50)
        //        {
        //            throw new IndexOutOfRangeException ("Number of wheels exceeds the number of wheels for vehicles");
        //        }
        //        numberOfWheels = value;
        //    }
        //}



        // Move to GarageHandler?
        //public virtual VehicleProperties CreateVehicle()
        //{
        //    VehicleProperties VehicleAttrib = new VehicleProperties();
        //    //Validate.SetString(Color, "Must be entered in numbers and be less than 50", (valid) => { return true ? valid < 50 : false; });
        //    //color = Color;
        //    //type = Type;
        //    //registrationNumber = RegistrationNumber;
        //    Validate.SetInt(VehicleAttrib.NumberOfWheels, "Enter number of wheels for vehicle. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });


        //    return vehicleProperties;


        //}

    }

    //internal class Car : Vehicle
    //{
    //    public Car(VehicleProperties vehicleProperties) : base(vehicleProperties)
    //    {
            
    //    }
    //}
}
