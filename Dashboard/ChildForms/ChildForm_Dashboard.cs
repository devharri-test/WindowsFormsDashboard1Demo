using Dashboard.Models;
using LiveCharts;
using LiveCharts.Wpf;
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
            productionModelBindingSource.DataSource = new List<ProductionModel>();

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

            //Add data to DataGridView here 
            List<ProductionModel> PlcData = new List<ProductionModel>();
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 1, Value = 40 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 2, Value = 42 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 3, Value = 46 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 4, Value = 49 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 5, Value = 48 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 6, Value = 50 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 7, Value = 52 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 8, Value = 54 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 9, Value = 53 });
            PlcData.Add(new ProductionModel() { Shift = 1, Day = 10, Value = 58 });

            PlcData.Add(new ProductionModel() { Shift = 2, Day = 1, Value = 40 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 2, Value = 44 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 3, Value = 48 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 4, Value = 52 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 5, Value = 52 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 6, Value = 50 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 7, Value = 52 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 8, Value = 54 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 9, Value = 50 });
            PlcData.Add(new ProductionModel() { Shift = 2, Day = 10, Value = 58 });

            PlcData.Add(new ProductionModel() { Shift = 3, Day = 1, Value = 45 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 2, Value = 40 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 3, Value = 50 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 4, Value = 58 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 5, Value = 50 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 6, Value = 50 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 7, Value = 52 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 8, Value = 54 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 9, Value = 52 });
            PlcData.Add(new ProductionModel() { Shift = 3, Day = 10, Value = 50 });

            productionModelBindingSource.DataSource = PlcData;

            UpdateChart();
        }

        private void UpdateChart()
        {
            //Initilize data
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var shifts = (from o in productionModelBindingSource.DataSource as List<ProductionModel>
                          select new { Shift = o.Shift }).Distinct();
            foreach (var shift in shifts)
            {
                List<double> values = new List<double>();
                for (int day = 1; day <= 10; day++)
                {
                    double value = 0;
                    var data = from o in productionModelBindingSource.DataSource as List<ProductionModel>
                               where o.Shift.Equals(shift.Shift) && o.Day.Equals(day)
                               orderby o.Day ascending
                               select new { o.Value, o.Day };

                    try
                    {
                        if (data.SingleOrDefault() != null)
                        {

                            value = data.SingleOrDefault().Value;
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Invalid input. There is more than one element with same values");
                    }



                    values.Add(value);

                }
                series.Add(new LineSeries() { Title = shift.Shift.ToString(), Values = new ChartValues<double>(values), PointGeometrySize = 5, });

            }
            cartesianChart1.Series = series;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }
}
