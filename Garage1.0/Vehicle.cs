using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal abstract class Vehicle : IVehicle
    {
        //private string color;
        //private string type;
        //private string registrationNumber;
        //private int numberOfWheels;
        public VehicleAttribute VehicleAttribute { get; set; }

        public Vehicle(VehicleAttribute vehicleAttribute)
        {
            VehicleAttribute = vehicleAttribute;
        }
        
        public Vehicle(string regNo, string color)
        {
            var vehicleAttribute = new VehicleAttribute()
            {
                //RegistrationNumber = regNo,
                //Color = color
            };
        }



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
        //public virtual VehicleAttribute CreateVehicle()
        //{
        //    VehicleAttribute VehicleAttrib = new VehicleAttribute();
        //    //Validate.SetStringmember(Color, "Must be entered in numbers and be less than 50", (valid) => { return true ? valid < 50 : false; });
        //    //color = Color;
        //    //type = Type;
        //    //registrationNumber = RegistrationNumber;
        //    Validate.SetIntmember(VehicleAttrib.NumberOfWheels, "Enter number of wheels for vehicle. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 : false; });
            

        //    return vehicleAttribute;


        //}

    }

    internal class Car : Vehicle
    {
        public Car(VehicleAttribute attribute) : base(attribute)
        {
            
        }
    }
}
