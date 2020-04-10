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
    public partial class VehicleRentDetailForm : Form
    {
        private BindingSource _rentDetailBindingSource = new BindingSource();
        private VehicleRentDetailRepository _rentDetailRepository = new VehicleRentDetailRepository();
        public VehicleRentDetailForm()
        {
            InitializeComponent();
        }
        
        private void VehicleRentDetailForm_Load(object sender, EventArgs e)
        {
            retrieveDeserializeToolStripMenuItem_Click(sender, e);
        }

        private void newRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentCarForm rentCarForm = new RentCarForm();
            rentCarForm.MaximizeBox = false;
            var result = rentCarForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var newRentDetail = rentCarForm.VehicleRentDetail;
                newRentDetail.VehicleRentDetailId = _rentDetailRepository.GenerateId();
                _rentDetailBindingSource.Add(newRentDetail);
                _rentDetailRepository.SaveRentDetails((List<VehicleRentDetail>)_rentDetailBindingSource.DataSource);

            }
        }
        
        private void retrieveDeserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to display in grid
            _rentDetailBindingSource.DataSource = _rentDetailRepository.GetRentDetails();

            //if set to true creates a new object if the list is empty.
            _rentDetailBindingSource.AllowNew = false;

            rentDetailGridView.DataSource = _rentDetailBindingSource;
            rentDetailGridView.ReadOnly = true;
        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retriveDeserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveSerializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
