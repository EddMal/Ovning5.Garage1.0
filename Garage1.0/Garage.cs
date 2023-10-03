using System;
using System.Collections.Generic;
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


    internal class Garage<T> where T : IVehicle
    {
        private T[] slots;

        public Garage(int capacity)
        {
            slots = new T[capacity]; 
        }

        internal void Park(T vehicle)
        {
            //Add to slots
        }
    }
}
