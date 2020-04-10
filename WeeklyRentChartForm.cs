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
    public partial class WeeklyRentChartForm : Form
    {
        private VehicleRentDetailRepository _rentDetailRepository = new VehicleRentDetailRepository();
        private List<VehicleRentDetail> _rentDetailList = new List<VehicleRentDetail>();
        public WeeklyRentChartForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadRentDetail();
            FillChart();
        }

        private void LoadRentDetail()
        {
            _rentDetailList = _rentDetailRepository.GetWeeksData();
        }
        private void FillChart()
        {
            foreach (var rentDetail in _rentDetailList)
            {
                rentDetailChart.Series["RentDetail"].Points.AddXY(rentDetail.Date.DayOfWeek.ToString(), rentDetail.TotalHours.ToString());
            }
        }

       

    }
}
