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
    public partial class GyroGeometryForm : Form
    {
        private double _length;
        private double _width;
        private double _height;
        private MEMSGyroModel gyroModel;
        public GyroGeometryForm()
        {
            InitializeComponent();
        }

        private void GyroGeometryForm_Load(object sender, EventArgs e)
        {

        }

        private MEMSGyroModel InitializeModel(double length, double width, double height, string path)
        {
            MEMSGyroModel._userPath = path;
            if (gyroModel == null)
            {
                gyroModel = new MEMSGyroModel();
            }
            gyroModel.length = length;
            gyroModel.width = width;
            gyroModel.height = height;
            return gyroModel;
        }

        private async void btnRebuild_Click(object sender, EventArgs e)
        {
            _length = Convert.ToDouble(txtLength.Text) / 1000;
            _width = Convert.ToDouble(txtWidth.Text) / 1000;
            _height = Convert.ToDouble(txtHeight.Text) / 1000;

            btnRebuild.Enabled = false;
            rebuildPrg.Show();

            await Task.Run(() => InitializeModel(_length, _width, _height, txt_ResultPath.Text).RebuildModel());

            btnRebuild.Enabled = true;
            rebuildPrg.Hide();
            btnToSimulation.Enabled = true;
        }

        private void ResetEnable()
        {
            if (btnReset.Enabled == false) btnReset.Enabled = true;
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            ResetEnable();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            ResetEnable();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            ResetEnable();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLength.Text = Convert.ToString(MEMSGyroModel.lengthOrig * 1000);
            txtWidth.Text = Convert.ToString(MEMSGyroModel.widthOrig * 1000);
            txtHeight.Text = Convert.ToString(MEMSGyroModel.heightOrig * 1000);
        }

        private void btnToSimulation_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Did you open / rebuild your model before starting simulation?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if ( dialogResult == DialogResult.Yes )
            {
                new GyroAnalysisForm(this, gyroModel).Show();
                Hide();
            }
        }

        private void txt_ResultPath_TextChanged(object sender, EventArgs e)
        {
            btnRebuild.Enabled = true;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txt_ResultPath.Text = folderBrowser.SelectedPath;
            }
            else
            {
                MessageBox.Show("Invalid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
