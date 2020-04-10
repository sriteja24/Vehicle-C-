using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRental
{
    public class VehicleRentDetailRepository
    {
        private List<VehicleRentDetail> _vehicleRentDetailList = new List<VehicleRentDetail>();
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath);

        private void DeSerializeVehicleData()
        {
            if (File.Exists(filePath + @"\vehicleRentDetail.dat"))
            {
                Stream stream = File.Open(filePath + @"\vehicleRentDetail.dat", FileMode.Open);
                if (stream != null && stream.Length > 0)
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    //Reading VehicleRentDetail Information
                    _vehicleRentDetailList = (List<VehicleRentDetail>)binaryFormatter.Deserialize(stream);

                    MessageBox.Show("VehicleRent Details retrieved from file");
                }
                stream.Close();
            }

        }

        private void SerializeVehicleData(List<VehicleRentDetail> rentDetails)
        {
            Stream str = File.Open(filePath + @"\vehicleRentDetail.dat", FileMode.Create);
            BinaryFormatter bF = new BinaryFormatter();
            bF.Serialize(str, rentDetails);
            str.Flush();
            str.Close();
            MessageBox.Show("Vehicle Rent Detail saved to file");
        }

        public List<VehicleRentDetail> ReadFromCSV(string csvString)
        {
            var vehicleRentDetailList = new List<VehicleRentDetail>();
            var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);

            foreach (var item in lines)
            {
                var values = item.Split(',');
                var rentDetail = new VehicleRentDetail();
                rentDetail.VehicleRentDetailId = Convert.ToInt32(values[0]);
                rentDetail.VehicleName = Convert.ToString(values[1]);
                rentDetail.Date = Convert.ToDateTime(values[2]);
                rentDetail.InTime = Convert.ToDateTime(values[3]).TimeOfDay;
                rentDetail.OutTime = Convert.ToDateTime(values[4]).TimeOfDay;

                vehicleRentDetailList.Add(rentDetail);
            }
            _vehicleRentDetailList = vehicleRentDetailList;
            return vehicleRentDetailList;
        }

        public void ExportToCSV(List<VehicleRentDetail> rentDetails, string filePath)
        {
            if (rentDetails.Count > 0)
            {
                var propList = rentDetails[0].GetType().GetProperties().Select(prop => prop.Name).ToList();
                //TextWriter is used to create outputand streamWriter is used to read file location

                using (TextWriter TW = new StreamWriter(filePath, append: true))
                {
                    //writes header
                    foreach (var prop in propList)
                    {
                        TW.Write(prop.ToString() + ",");
                    }
                    TW.WriteLine();
                    //writes values
                    foreach (var val in rentDetails)
                    {
                        foreach (PropertyInfo prop in val.GetType().GetProperties())
                        {
                            TW.Write(prop.GetValue(val, null).ToString() + ",");
                        }
                        TW.WriteLine();

                    }
                }
                MessageBox.Show("Your records is saved successfully.");
                Process.Start(filePath);
            }
        }


        public List<VehicleRentDetail> GetRentDetails()
        {
            DeSerializeVehicleData();
            if (_vehicleRentDetailList != null && _vehicleRentDetailList.Count > 0)
            {
                return _vehicleRentDetailList;
            }
            else
            {
                _vehicleRentDetailList = new List<VehicleRentDetail>();
                return _vehicleRentDetailList;
            }

        }
        public void SaveRentDetails(List<VehicleRentDetail> rentDetails)
        {
            SerializeVehicleData(rentDetails);
        }

        public int GenerateId()
        {
            int id = 0;
            if (_vehicleRentDetailList != null && _vehicleRentDetailList.Count > 0)
            {
                id = _vehicleRentDetailList.Max(a => a.VehicleRentDetailId);
            }

            return id + 1;
        }



        public List<VehicleRentDetail> GetWeeksData()
        {
            DeSerializeVehicleData();
            if (_vehicleRentDetailList != null && _vehicleRentDetailList.Count > 0)
            {
                //set to start of week i.e Monday of current week.
                var startOfWeek = DateTime.Now.AddDays(((int)DateTime.Now.DayOfWeek * -1) + 1);
                //set time as 10:00:00
                startOfWeek = new DateTime(startOfWeek.Year, startOfWeek.Month, startOfWeek.Day, 00, 0, 0);

                //set end of week i,e Friday of current we
                var endOfWeek = startOfWeek.AddDays(4);
                //set time as 17:00:00
                endOfWeek = new DateTime(endOfWeek.Year, endOfWeek.Month, endOfWeek.Day, 18, 0, 0);
                //where rentDetail.Date >= startOfWeek
                //                  && rentDetail.Date <= endOfWeek
                //get only this weeks data

                var weeklyData = (from rentDetail in _vehicleRentDetailList
                                  where rentDetail.Date >= startOfWeek
                                  && rentDetail.Date <= endOfWeek
                                  group rentDetail by rentDetail.Date into grp //groups data by date.
                                  select new VehicleRentDetail
                                  {
                                      Date = grp.Max(a => a.Date), //gets maximum value of date selected.
                                      TotalHours = grp.Sum(a => a.TotalHours) //get sum of total hours on that day.
                                  }).OrderByDescending(a => a.TotalHours).ToList(); //orders the data in descending order and returns a list.
                return weeklyData;
            }
            else
            {
                _vehicleRentDetailList = new List<VehicleRentDetail>();
                return _vehicleRentDetailList;
            }
        }
    }
}
