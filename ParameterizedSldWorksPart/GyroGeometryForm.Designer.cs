namespace ParameterizedSldWorksPart
{
    partial class GyroGeometryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnToSimulation = new System.Windows.Forms.Button();
            this.rebuildPrg = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ResultPath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "Automatic vibration gyroscope modeling";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRebuild
            // 
            this.btnRebuild.Enabled = false;
            this.btnRebuild.Location = new System.Drawing.Point(120, 407);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(242, 35);
            this.btnRebuild.TabIndex = 15;
            this.btnRebuild.Text = "Open/Rebuild Model";
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnRebuild_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(78, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Height (μm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(78, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Width (μm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Length (μm)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(176, 300);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(222, 22);
            this.txtHeight.TabIndex = 11;
            this.txtHeight.Text = "40";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(176, 247);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(222, 22);
            this.txtWidth.TabIndex = 10;
            this.txtWidth.Text = "360";
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(176, 197);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(222, 22);
            this.txtLength.TabIndex = 9;
            this.txtLength.Text = "410";
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(77, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Input sizes of driven mass or use defaults:";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(120, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(242, 35);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset to defaults";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(157, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 61);
            this.label6.TabIndex = 18;
            this.label6.Text = "Simulation";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToSimulation
            // 
            this.btnToSimulation.Enabled = false;
            this.btnToSimulation.Location = new System.Drawing.Point(113, 600);
            this.btnToSimulation.Name = "btnToSimulation";
            this.btnToSimulation.Size = new System.Drawing.Size(249, 35);
            this.btnToSimulation.TabIndex = 19;
            this.btnToSimulation.Text = "Configure and Run Simulation";
            this.btnToSimulation.UseVisualStyleBackColor = true;
            this.btnToSimulation.Click += new System.EventHandler(this.btnToSimulation_Click);
            // 
            // rebuildPrg
            // 
            this.rebuildPrg.Location = new System.Drawing.Point(120, 510);
            this.rebuildPrg.MarqueeAnimationSpeed = 30;
            this.rebuildPrg.Name = "rebuildPrg";
            this.rebuildPrg.Size = new System.Drawing.Size(242, 23);
            this.rebuildPrg.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.rebuildPrg.TabIndex = 20;
            this.rebuildPrg.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ParameterizedSldWorksPart.Properties.Resources.gyro_sizes;
            this.pictureBox2.Location = new System.Drawing.Point(481, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(557, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParameterizedSldWorksPart.Properties.Resources.gyro_trimetric;
            this.pictureBox1.Location = new System.Drawing.Point(481, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_ResultPath
            // 
            this.txt_ResultPath.Enabled = false;
            this.txt_ResultPath.Location = new System.Drawing.Point(81, 354);
            this.txt_ResultPath.Name = "txt_ResultPath";
            this.txt_ResultPath.Size = new System.Drawing.Size(222, 22);
            this.txt_ResultPath.TabIndex = 21;
            this.txt_ResultPath.Text = "Your data/results directory";
            this.txt_ResultPath.TextChanged += new System.EventHandler(this.txt_ResultPath_TextChanged);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(321, 354);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(77, 23);
            this.btn_Browse.TabIndex = 22;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // GyroGeometryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 741);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txt_ResultPath);
            this.Controls.Add(this.rebuildPrg);
            this.Controls.Add(this.btnToSimulation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRebuild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GyroGeometryForm";
            this.Text = "MEMS-Gyroscope";
            this.Load += new System.EventHandler(this.GyroGeometryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnToSimulation;
        private System.Windows.Forms.ProgressBar rebuildPrg;
        private System.Windows.Forms.TextBox txt_ResultPath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}