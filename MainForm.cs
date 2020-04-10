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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the form is already open
            Form openForm = Application.OpenForms["VehicleDetailForm"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                VehicleDetailForm vehicleDetail = new VehicleDetailForm();
                vehicleDetail.MdiParent = this;
                vehicleDetail.Show();
            }

        }

        private void detailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //check if the form is already open
            Form openForm = Application.OpenForms["VehicleRentDetailForm"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                VehicleRentDetailForm vehicleRentDetailForm = new VehicleRentDetailForm();
                vehicleRentDetailForm.MdiParent = this;
                vehicleRentDetailForm.Show();
            }
        }

        private void rentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the form is already open
            Form openForm = Application.OpenForms["reportForm"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                WeeklyRentChartForm reportForm = new WeeklyRentChartForm();
                reportForm.MdiParent = this;
                reportForm.Show();
            }
        }
    }
}
