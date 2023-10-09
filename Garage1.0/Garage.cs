using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    //Specifikationer:
    //Själva garaget ska implementeras som en generisk samling av fordon: class Garage<T>
    //Dessutom ska den generiska typen begränsas med hjälp av en constraint:class Garage<T> where ....

    //Vidare ska det gå att iterera över en instans av Garage med hjälp av foreach. Det innebär
    //att Garage ska implementera den generiska varianten av interfacet IEnumerable:
    //class Garage<T> : ....

    //Klassen behöver inte ärva från någon annan klass eller implementera något annat
    //interface.

    //Samlingen av fordon ska internt i klassen hanteras som en array, dvs Vehicle[]. Den
    //interna arrayen ska var privat.Vid instansieringen av ett nytt garage måste kapaciteten
    //anges som argument till konstruktorn.

    //Vi ska EJ använda oss av en List<Vehicle> internt i Garage klassen!!!

    //Skapa ett garage med en användar specificerad storlek(storlek sätts genom IHandler)


    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] slots;
        private int count;

        public Garage(int capacity)
        {
            slots = new T[capacity];
        }

        internal void Park(T vehicle)
        {
            if (count <= slots.Length)
            {
                slots[count] = vehicle;
                this.count++;
            }
            else
            {
                ConsoleUI.PrintData($"Garage is full.");
            }
        }

        internal bool Remove(string registrationNumber)
        {
            string propertyString;
            int countIndex = 0;
            bool itemRemoved = false;
            T[] replaceSlotts = new T[count - 1];
            registrationNumber += registrationNumber.ToUpper();
            foreach (var item in slots)
            {
                foreach (var property in item.vehicleProperties)
                {
                    propertyString = property.ToString();
                    propertyString += propertyString.ToUpper();
                    if (propertyString == registrationNumber)
                    {
                        itemRemoved = true;
                    }
                    else
                    {

                        replaceSlotts[countIndex] = item;
                    }
                }
                countIndex++;
            }
        
            if(countIndex < count)
            {
            this.count--;
            slots = replaceSlotts;
            }

            return itemRemoved;

        }

        internal (object[], bool) SearchMatchingProperty(string vehicleProperty,Func<string,bool> condition)
        {
            //redudant?
            string vehicleproperty = vehicleProperty.ToUpper();
            bool itemFound = false;
            int countIndex = 0;
            int countSlots = 0;
            object[] matchingVehiclesHolder = new object[count];
            while (countSlots < this.count)
            {
                foreach (var item in slots)
                {
                    for (int i = 0; i < item.vehicleProperties.Length; i++ )
                    {

                        string temp = item.vehicleProperties[i].ToString();
                        temp = temp.ToUpper();
                        if (condition(temp) == true)
                        {

                            itemFound = true;
                            matchingVehiclesHolder[countIndex] = item.vehicleProperties[i];
                            countIndex++;
                        }
                    }

                }
            }
            object[] matchingVehicles = new object[countIndex];
            foreach (var vehicle in matchingVehiclesHolder)
            {
                matchingVehicles = matchingVehiclesHolder;
            }
            return (matchingVehicles, itemFound);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in slots)
            {
                //additional condition/function?
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
