using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRental
{
    public partial class VehicleDetailForm : Form
    {
        //repository class has all the logic to save and retrieve data.
        //making a object of VehicleRepository class.
        private VehicleRepository _vehicleRepository = new VehicleRepository();
        //making object of BindingSource clss to store Vehicle data.
        private BindingSource _vehicleBindingSource = new BindingSource();

        //default generated constructor.
        public VehicleDetailForm()
        {
            InitializeComponent();
        }

        //this function is called when the form loads.
        private void VehicleDetailForm_Load(object sender, EventArgs e)
        {
            //calls this method to get the vehicle list.
            retrieveDeserializeToolStripMenuItem_Click(sender, e);
        }
        //function to get data.
        //this function calls the GetVehicleMethod from VehicleRepository class
        private void retrieveDeserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Step 1: Get Vehicle Data from GetVehicles method of _vehicleRepository class.
            //Step 2: Store it in the _vehicleBindingSource.DataSource
            _vehicleBindingSource.DataSource = _vehicleRepository.GetVehicles(); //click on GetVehicles and press f12 to navigate to the function

            //if set to true creates a new object if the list is empty.
            _vehicleBindingSource.AllowNew = false;

            //display data in the binding source in the grid.
            //assign the list to the grid.
            vehicleListGridView.DataSource = _vehicleBindingSource;
            //making the grid readonly.
            vehicleListGridView.ReadOnly = true;
        }

        //opens a dialog box of VehicleRegisterForm 
        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            //step 1: create object of VehicleRegisterForm
            VehicleRegisterForm vechileRegisterForm = new VehicleRegisterForm();
            vechileRegisterForm.MaximizeBox = false;
            //step 2: open the form in dialog box and store the result.
            var result = vechileRegisterForm.ShowDialog(this);
            //step 3: check if user has pressed OK button
            if (result == DialogResult.OK)
            {
                //store the data from dialog box to a variable.
                var newVehicle = vechileRegisterForm.Vehicle;
                //generate unique id and store.
                newVehicle.VehicleId = _vehicleRepository.GenerateId();
                //add to the grid
                _vehicleBindingSource.Add(newVehicle);
                //save to the object state file.
                _vehicleRepository.SaveVehicles((List<Vehicle>)_vehicleBindingSource.DataSource);

            }
        }

        private void importVehicle_Click(object sender, EventArgs e)
        {
            //step 1: create an instance of windows default open dialog box.
            var dialog = new OpenFileDialog();
            //step 2: set filter so that it shows only csv files.
            dialog.Filter = "CSV files|*.csv";

            //step 3: open the dialog box
            var result = dialog.ShowDialog();

            //check if  user has clicked OK.
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //Step 1: read all the lines in the csv file
                var csvString = File.ReadAllText(dialog.FileName);
                //Step 2: Pass the csvString to ReadFromCSV method from _vehicleRepository class
                //Step 3: Save the value to the binding source. (Binding Source is used by our grid).
                _vehicleBindingSource.DataSource = _vehicleRepository.ReadFromCSV(csvString);
            }
        }

        private void exportVehicleDialog_Click(object sender, EventArgs e)
        {
            //step 1: create an instance of windows default save dialog box.
            var dialog = new SaveFileDialog();
            //step 2: set filter so that the file can be saved with extenstion .csv.
            dialog.Filter = "CSV File|*.csv";
            dialog.AddExtension = true;
            //step 3: open the save dialog box
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //export filename and our data list to the ExportToCSV class.
                _vehicleRepository.ExportToCSV((List<Vehicle>)_vehicleBindingSource.DataSource, dialog.FileName);
            }
        }

        //this function calls SaveVehicles class and pass the data list the class.
        private void saveSerializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _vehicleRepository.SaveVehicles((List<Vehicle>)_vehicleBindingSource.DataSource);
        }


        //calls SortUsingMakeYear() method and stores the output to  _vehicleBindingSource.DataSource
        private void sortByMakeYearBubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _vehicleBindingSource.DataSource = _vehicleRepository.SortUsingMakeYear();

            //refresh the grid to view the output.
            vehicleListGridView.Refresh();
        }
    }
}
