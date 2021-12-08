using Dashboard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class ChildForm_Charts : Form
    {
        public ChildForm_Charts()
        {
            InitializeComponent();
        }

        private void ChildForm_Charts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<ProductionModel>();

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {

                Title = "Day",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Production",
                LabelFormatter = value => value + "pcs"
            });

            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }
    }
}
