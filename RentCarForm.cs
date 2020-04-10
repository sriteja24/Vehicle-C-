using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRental
{
    public partial class RentCarForm : Form
    {
        private VehicleRepository _vehicleRepository = new VehicleRepository();
        private BindingSource _vehicleBindingSource = new BindingSource();
        private string filePath;

        public RentCarForm()
        {
            InitializeComponent();
        }

        //this method is called when the rent car form loads.
        //it calls GetVehicleData method to get rent details
        private void RentCarForm_Load(object sender, EventArgs e)
        {
            GetVehicleData(sender, e);
        }

        private void GetVehicleData(object sender, EventArgs e)
        {
            //to display in grid
            //it get's vehicle data from vehicleRepository class.
            _vehicleBindingSource.DataSource = _vehicleRepository.GetVehicles();

            //if set to true creates a new object if the list is empty.
            _vehicleBindingSource.AllowNew = false;

            vehicleComboBOx.DataSource = _vehicleBindingSource;
            vehicleComboBOx.DisplayMember = "VehicleName";
            vehicleComboBOx.ValueMember = "VehicleName";
        }
        
        public VehicleRentDetail VehicleRentDetail
        {
            get
            {
                var rentDetail = new VehicleRentDetail();
                rentDetail.VehicleName = Convert.ToString(vehicleComboBOx.SelectedValue);
                rentDetail.Date = datePicker.Value.Date;
                rentDetail.InTime = inTimePicker.Value.TimeOfDay;
                rentDetail.OutTime = outTimeDatePicker.Value.TimeOfDay;
                rentDetail.TotalHours = rentDetail.CalculateTotalHours();
                return rentDetail;
            }
        }

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
    }
}
