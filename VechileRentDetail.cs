using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    [Serializable()]
    public class VehicleRentDetail : ISerializable
    {
        public int VehicleRentDetailId { get; set; }
        public string VehicleName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan OutTime { get; set; }
        public double TotalHours { get; set; }

        //needed for serialization
        public static string KEY = "VehicleRentDetailId";
        public static string KEY1 = "VehicleName";
        public static string KEY2 = "Date";
        public static string KEY3 = "InTime";
        public static string KEY4 = "OutTime";
        public static string KEY5 = "TotalHours";


        //Deserialization constructor.
        public VehicleRentDetail(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties

            VehicleRentDetailId = (int)serial.GetValue(KEY, typeof(int));
            VehicleName = (string)serial.GetValue(KEY1, typeof(string));
            Date = (DateTime)serial.GetValue(KEY2, typeof(DateTime));
            InTime = (TimeSpan)serial.GetValue(KEY3, typeof(TimeSpan));
            OutTime = (TimeSpan)serial.GetValue(KEY4, typeof(TimeSpan));
            TotalHours = (double)serial.GetValue(KEY5, typeof(double));
        }

        //default constructor
        public VehicleRentDetail() { }

        //needed for serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue(KEY, VehicleRentDetailId);
            info.AddValue(KEY1, VehicleName);
            info.AddValue(KEY2, Date);
            info.AddValue(KEY3, InTime);
            info.AddValue(KEY4, OutTime);
            info.AddValue(KEY5, TotalHours);
        }

        public double CalculateTotalHours()
        {
            return OutTime.Subtract(InTime).Hours;
        }

    }
}
