using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class GarageProperties
    {


        //private int capacity;
        //public int Capacity
        //{
        //    get => capacity;
        //    protected set
        //    {
        //        if (value <= 80 && value >= 10)
        //        {
        //            throw new IndexOutOfRangeException("Garage capacity must bee within range 10 to 80.");
        //        }
        //        capacity = value;
        //    }
        //}
        //Change nonstatic?.
        public static int SetCapacity() 
        {
            //Validated validated = new Validated();
            int capacity = Validated.SetInt("Set garage capacity, minimum capacity is 10 slots max capacity is 80 slots.", (valid) => { return true ? valid < 80 && valid > 9 : false; });
            return capacity;
        }

        public static object[][] PopulateGarage()
        {
            //should use a vehicle with vehicleProperties instead of new object to assure the order is correct.
            object[][] initiate;
            object[] initiateTemp;
            initiate = new object[6][];
            string[] number = {"3","4","5","6","7","8"};

            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                {
                    initiateTemp = new object[]{ "grey", "xxx-12" + $"{number[i]}", 4, "Volvo"};
                    initiate[i] = initiateTemp;


                }
                else
                {
                    initiateTemp = new object[] { "grey", "xxx-12" + $"{number[i]}", 4, "Saab"};
                    initiate[i] = initiateTemp;
                }
            }
            return initiate;
            

        }
    }
}
