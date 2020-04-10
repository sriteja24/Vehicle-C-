using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    //Class should extend the functionality of serialization to use it's methods.
    [Serializable()]
    public class Vehicle : ISerializable
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string Manufacturer { get; set; }
        public string MakeYear { get; set; }
        
        //needed for serialization
        //making key value pairs.
        public static string KEY = "VehicleId";
        public static string KEY1 = "VehicleName";
        public static string KEY2 = "Manufacturer";
        public static string KEY3 = "MakeYear";

        //default constructor
        public Vehicle() { }


        //Deserialization constructor.
        //gets value from object data and converts to c# property.
        public Vehicle(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties
            VehicleId = (int)serial.GetValue(KEY, typeof(int));
            VehicleName = (string)serial.GetValue(KEY1, typeof(string));
            Manufacturer = (string)serial.GetValue(KEY2, typeof(string));
            MakeYear = (string)serial.GetValue(KEY3, typeof(string));
        }

        //Serialize Method.
        //this method converts the properties to object data using Key value mentioned above
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue(KEY, VehicleId);
            info.AddValue(KEY1, VehicleName);
            info.AddValue(KEY2, Manufacturer);
            info.AddValue(KEY3, MakeYear);
        }


    }
}
