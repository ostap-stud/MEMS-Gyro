using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ParameterizedSldWorksPart
{
    public partial class GyroResponsePlotForm : Form
    {
        List<List<double>> _data = new List<List<double>>();
        private GyroAnalysisForm _previousForm;
        private MEMSGyroModel _gyroModel;

        public GyroResponsePlotForm(object[] data, GyroAnalysisForm previous, MEMSGyroModel gyroModel)
        {
            InitializeComponent();
            _previousForm = previous;
            _gyroModel = gyroModel;

            nodeUpDown.Minimum = 1;
            nodeUpDown.Maximum = gyroModel.nodesNumber;
            nodeUpDown.Value = 1839;

            ChartFeatures();
            SetChartData(data, $"Node {nodeUpDown.Value}");
            
        }

        private void GyroResponsePlotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _previousForm.Show();
        }

        private void frequencyRespChart_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAddResp_Click(object sender, EventArgs e)
        {
            SetChartData(_gyroModel.GetDataAtNode(Convert.ToInt32(nodeUpDown.Value)), $"Node {nodeUpDown.Value}");
        }

        private void ChartFeatures()
        {
            ChartArea chartArea = frequencyRespChart.ChartAreas[0];
            chartArea.AxisX.LabelStyle.Format = "#0.0e0";
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.CursorX.AutoScroll = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.AxisY.Title = "Acceleration-Z Amp. (mm/s\xB2)";
            chartArea.AxisX.Title = "Frequency (Hz)";
        }

        private void SetChartData(object[] data, string seriesName)
        {
            if (frequencyRespChart.Series.FindByName(seriesName) == null)
            {
                frequencyRespChart.Series.Add(seriesName);
                frequencyRespChart.Series[seriesName].BorderWidth = 3;
                frequencyRespChart.Series[seriesName].ChartType = SeriesChartType.Spline;
                frequencyRespChart.Series[seriesName].ToolTip = "X = #VALX, Y = #VALY";

                frequencyRespChart.Series[seriesName].MarkerStyle = MarkerStyle.Circle;
                frequencyRespChart.Series[seriesName].MarkerSize = 7;

                for (int i = 1; i < data.Length; i += 3)
                {
                    frequencyRespChart.Series[seriesName].Points.AddXY(Convert.ToDouble(data[i]), Convert.ToDouble(data[i + 1]));
                }
            }
            else
            {
                MessageBox.Show("Graph for that node already plotted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
