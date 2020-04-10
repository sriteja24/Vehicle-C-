using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRental
{
    public partial class VehicleRegisterForm : Form
    {
        public VehicleRegisterForm()
        {
            InitializeComponent();
        }
        //this property has only get accessor.
        //it is called when the user press OK button
        public Vehicle Vehicle
        {
            get
            {
                var vehicle = new Vehicle();
                vehicle.VehicleName = vehicleNameTextBox.Text;
                vehicle.Manufacturer = manufacturerTextBox.Text;
                vehicle.MakeYear = makeYearTextBox.Text;
                return vehicle;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }
    }
}
