namespace ParameterizedSldWorksPart
{
    partial class GyroResponsePlotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.frequencyRespChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nodeUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnAddResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyRespChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(422, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acceleration Frequency Response";
            // 
            // frequencyRespChart
            // 
            this.frequencyRespChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea2.Name = "ChartArea1";
            this.frequencyRespChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Name = "Legend1";
            this.frequencyRespChart.Legends.Add(legend2);
            this.frequencyRespChart.Location = new System.Drawing.Point(308, 108);
            this.frequencyRespChart.Name = "frequencyRespChart";
            this.frequencyRespChart.Size = new System.Drawing.Size(861, 528);
            this.frequencyRespChart.TabIndex = 1;
            this.frequencyRespChart.Text = "chart1";
            this.frequencyRespChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frequencyRespChart_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add response series for node:";
            // 
            // nodeUpDown
            // 
            this.nodeUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nodeUpDown.Location = new System.Drawing.Point(91, 300);
            this.nodeUpDown.Name = "nodeUpDown";
            this.nodeUpDown.Size = new System.Drawing.Size(120, 22);
            this.nodeUpDown.TabIndex = 3;
            // 
            // btnAddResp
            // 
            this.btnAddResp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddResp.Location = new System.Drawing.Point(40, 344);
            this.btnAddResp.Name = "btnAddResp";
            this.btnAddResp.Size = new System.Drawing.Size(230, 36);
            this.btnAddResp.TabIndex = 4;
            this.btnAddResp.Text = "Add Response Graph";
            this.btnAddResp.UseVisualStyleBackColor = true;
            this.btnAddResp.Click += new System.EventHandler(this.btnAddResp_Click);
            // 
            // GyroResponsePlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 648);
            this.Controls.Add(this.btnAddResp);
            this.Controls.Add(this.nodeUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frequencyRespChart);
            this.Controls.Add(this.label1);
            this.Name = "GyroResponsePlotForm";
            this.Text = "MEMS-Gyroscope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GyroResponsePlotForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.frequencyRespChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart frequencyRespChart;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nodeUpDown;
        private System.Windows.Forms.Button btnAddResp;
    }
}