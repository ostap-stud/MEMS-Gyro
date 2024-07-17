using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterizedSldWorksPart
{
    public partial class GyroAnalysisForm : Form
    {
        private GyroGeometryForm _previous;
        MEMSGyroModel _gyroModel;
        private int _numOfFreq;
        private int _upperBound;
        bool _useBoundOrFreq;
        public GyroAnalysisForm(GyroGeometryForm previous, MEMSGyroModel gyroModel)
        {
            InitializeComponent();
            _previous = previous;
            _gyroModel = gyroModel;
        }

        private void restraintsCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GyroAnalysisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _previous.Show();
        }

        private void rbUpperBound_CheckedChanged(object sender, EventArgs e)
        {
            txt_NumFreq.Enabled = false;
            txt_UpperBound.Enabled = true;
        }

        private void rbNumOfFreq_CheckedChanged(object sender, EventArgs e)
        {
            txt_NumFreq.Enabled = true;
            txt_UpperBound.Enabled = false;
        }

        private async void btnFreqSimulation_Click(object sender, EventArgs e)
        {
            btnFreqSimulation.Enabled = false;
            btnHarmSimulation.Enabled = false;
            freqPrg.Show();

            await Task.Run(() => _gyroModel.FrequencyModelSimulation(getCheckedItemsNames(), getMaterialName(), getUpperBound(), getNumOfFreq(), useBoundOrFreq()));

            btnFreqSimulation.Enabled = true;
            freqPrg.Hide();

            txtHarmNumFreq.Enabled = true;
            txtHarmNumPoints.Enabled = true;
            txtHarmDamping.Enabled = true;
            excitationFacesBox.Enabled = true;
            btnHarmSimulation.Enabled = true;
        }

        private bool useBoundOrFreq()
        {
            _useBoundOrFreq = rbUpperBound.Checked;
            return _useBoundOrFreq;
        }

        private int getUpperBound()
        {
            _upperBound = 100_000;
            if (txt_UpperBound.Text.Length != 0)
            {
                _upperBound = Convert.ToInt32(txt_UpperBound.Text);
            }
            return _upperBound;
        }

        private int getNumOfFreq()
        {
            _numOfFreq = 5;
            if (txt_NumFreq.Text.Length != 0)
            {
                _numOfFreq = Convert.ToInt32(txt_NumFreq.Text);
            }
            return _numOfFreq;
        }

        private string getMaterialName()
        {
            if (rbSilicon.Checked)
            {
                return "Silicon";
            }
            else if (rbNickel.Checked)
            {
                return rbNickel.Text;
            }
            else if (rbAlum.Checked)
            {
                return "1060 Alloy";
            }
            return null;
        }

        private List<string> getCheckedItemsNames()
        {
            List<string> itemsNames = null;
            if (restraintsCheckBox.CheckedItems.Count != 0)
            {
                itemsNames = new List<string>();
                for (int i = 0; i < restraintsCheckBox.CheckedItems.Count; i++)
                {
                    if (restraintsCheckBox.CheckedItems[i].Equals("Anchors"))
                    {
                        itemsNames.AddRange(MEMSGyroModel.anchors);
                    }
                    else if (restraintsCheckBox.CheckedItems[i].Equals("Base-Bottom"))
                    {
                        itemsNames.Add("Base-Bottom");
                    }
                }
            }
            return itemsNames;
        }

        private async void btnHarmSimulation_Click(object sender, EventArgs e)
        {
            object[] data = null;
            try
            {
                btnFreqSimulation.Enabled = false;
                btnHarmSimulation.Enabled = false;
                harmonicPrg.Show();
                await Task.Run(() => data = _gyroModel.HarmonicModelSimulation(getAccelerationFace(), getHarmNumOfFreq(), GetNumOfPoints(), GetDampingCoef()) );
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                btnFreqSimulation.Enabled = true;
                btnHarmSimulation.Enabled = true;
                harmonicPrg.Hide();
                
            }
            new GyroResponsePlotForm(data, this, _gyroModel).Show();
            Hide();
        }

        private double GetDampingCoef()
        {
            double coef = 0.05;
            if(txtHarmDamping.Text.Length > 0)
            {
                double temp = Convert.ToDouble(txtHarmDamping.Text.Replace('.', ','));
                if(temp >= 0.05 && temp <= 0.15)
                {
                    coef = temp;
                }
                else
                {
                    throw new ArgumentException("Input Damping coeffiecient value in range of 5-15%!");
                }
            }
            return coef;
        }

        private int GetNumOfPoints()
        {
            int numOfPoints = 6;
            if(txtHarmNumPoints.Text.Length > 0)
            {
                numOfPoints = Convert.ToInt32(txtHarmNumPoints.Text);
            }
            return numOfPoints;
        }

        private double getHarmNumOfFreq()
        {
            double numOfFreq = _gyroModel.resultNumOfFreq;
            if(txtHarmNumFreq.Text.Length > 0)
            {
                double tempNum = Convert.ToDouble(txtHarmNumFreq.Text);
                if (tempNum > _gyroModel.resultNumOfFreq)
                {
                    throw new ArgumentException("Number of freq. for Harmonic Study is too big!");
                }
                numOfFreq = tempNum;
            }
            return numOfFreq;
        }

        private string getAccelerationFace()
        {
            if (rbBottomFace.Checked) return rbBottomFace.Text;
            else if (rbTopFace.Checked) return rbTopFace.Text;
            return null;
        }

    }
}
