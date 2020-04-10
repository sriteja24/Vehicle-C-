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
    public class VehicleRepository
    {
        private List<Vehicle> _vehicleList = new List<Vehicle>();
        //file location to save object state. It is path of {project location}\bin\Debug
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath);

        //start: private methods of this class

        //gets object data from file location and converts to c# list.
        private void DeSerializeVehicleData()
        {
            try
            {
                //step 1: check if file exists
                if (File.Exists(filePath + @"\vehicleDetails.dat"))
                {
                    //step 2 : opens a stream to open the file
                    Stream stream = File.Open(filePath + @"\vehicleDetails.dat", FileMode.Open);

                    //step 3: check if file is null or emtpy.
                    if (stream != null && stream.Length > 0)
                    {
                        //BinaryFormatter class has method to convert .dat file to a c# list. i.e. deserialization.
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        //Step 4: Convert object state to c# list.
                        _vehicleList = (List<Vehicle>)binaryFormatter.Deserialize(stream);

                        MessageBox.Show("Vehicle Details retrieved from file");
                    }
                    //step 5: close the stream. after opening a stream it should always be closed.
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not able to get vehicle data. Please try later");
            }


        }
        //saves c# list object, converts to object data and saves in the file location.
        private void SerializeVehicleData(List<Vehicle> vehicles)
        {
            //step 1: create a new file/ opens the file if it already exisits.
            Stream str = File.Open(filePath + @"\vehicleDetails.dat", FileMode.Create);
            //BinaryFormatter class has method to convert  c# list to .dat file. i.e. serialization.
            BinaryFormatter bF = new BinaryFormatter();
            //step 2: convert c# list to .dat file.
            bF.Serialize(str, vehicles);
            //step 3: writes to the file.
            str.Flush();
            //step 4: close the stream.
            str.Close();
            MessageBox.Show("Vehicle Details saved to file");
        }

        //end: private methods of this class


        //start: public methods of this class. only these methods can be accessed by other classes

        //read from a csv file and conver it to c# object.
        public List<Vehicle> ReadFromCSV(string csvString)
        {
            var vehicleList = new List<Vehicle>();
            try
            {
                //1st row contains property name so skipping the first row.
                var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
                
                foreach (var item in lines)
                {
                    var values = item.Split(',');
                    var vehicle = new Vehicle();
                    vehicle.VehicleId = Convert.ToInt32(values[0]);
                    vehicle.VehicleName = values[1];
                    vehicle.Manufacturer = values[2];
                    vehicle.MakeYear = values[3];

                    vehicleList.Add(vehicle);
                }
                _vehicleList = vehicleList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not able to save vehicle data. Please try later");
            }
            return vehicleList;

        }

        //export the list to csv
        public void ExportToCSV(List<Vehicle> vehicles, string filePath)
        {
            try
            {
                if (vehicles.Count > 0)
                {
                    var propList = vehicles[0].GetType().GetProperties().Select(prop => prop.Name).ToList();
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
                        foreach (var val in vehicles)
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
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save records.");
            }

        }

        //reads vechicle data from object source and returns a list
        public List<Vehicle> GetVehicles()
        {
            //step 1: get data from the file.
            DeSerializeVehicleData();
            //check if it is null or empty.
            if (_vehicleList != null && _vehicleList.Count > 0)
            {
                return _vehicleList;
            }
            else
            {
                _vehicleList = new List<Vehicle>();
                return _vehicleList;
            }

        }

        //accepts list of vehicle and serializes the data to save as a object state.
        public void SaveVehicles(List<Vehicle> vehicles)
        {
            //call this method to save the file.
            SerializeVehicleData(vehicles);
        }

        //gets the latest identity id.
        public int GenerateId()
        {
            int id = 0;
            //checks if list is null or empty
            if (_vehicleList != null && _vehicleList.Count > 0)
            {
                id = _vehicleList.Max(a => a.VehicleId);
            }

            return id + 1;
        }

        //bubble sort example
        public List<Vehicle> SortUsingMakeYear()
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                for (int j = 0; j < _vehicleList.Count - 1; j++)
                {
                    var val1 = Convert.ToInt32(_vehicleList[j].MakeYear);
                    var val2 = Convert.ToInt32(_vehicleList[j + 1].MakeYear);
                    if (val1 > val2)
                    {
                        var temp = _vehicleList[j + 1];
                        _vehicleList[j + 1] = _vehicleList[j];
                        _vehicleList[j] = temp;
                    }
                }
            }
            return _vehicleList;
        }

        //end: public methods of this class. only these methods can be accessed by other classes

    }
}
