namespace ParameterizedSldWorksPart
{
    partial class GyroAnalysisForm
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
            this.txt_NumFreq = new System.Windows.Forms.TextBox();
            this.txt_UpperBound = new System.Windows.Forms.TextBox();
            this.materialSetBox = new System.Windows.Forms.GroupBox();
            this.rbAlum = new System.Windows.Forms.RadioButton();
            this.rbNickel = new System.Windows.Forms.RadioButton();
            this.rbSilicon = new System.Windows.Forms.RadioButton();
            this.restraintsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.btnFreqSimulation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHarmSimulation = new System.Windows.Forms.Button();
            this.excitationFacesBox = new System.Windows.Forms.GroupBox();
            this.rbTopFace = new System.Windows.Forms.RadioButton();
            this.rbBottomFace = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHarmNumPoints = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHarmNumFreq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHarmDamping = new System.Windows.Forms.TextBox();
            this.harmonicPrg = new System.Windows.Forms.ProgressBar();
            this.freqPrg = new System.Windows.Forms.ProgressBar();
            this.rbUpperBound = new System.Windows.Forms.RadioButton();
            this.rbNumOfFreq = new System.Windows.Forms.RadioButton();
            this.materialSetBox.SuspendLayout();
            this.excitationFacesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NumFreq
            // 
            this.txt_NumFreq.Location = new System.Drawing.Point(222, 142);
            this.txt_NumFreq.Name = "txt_NumFreq";
            this.txt_NumFreq.Size = new System.Drawing.Size(108, 22);
            this.txt_NumFreq.TabIndex = 21;
            // 
            // txt_UpperBound
            // 
            this.txt_UpperBound.Enabled = false;
            this.txt_UpperBound.Location = new System.Drawing.Point(94, 142);
            this.txt_UpperBound.Name = "txt_UpperBound";
            this.txt_UpperBound.Size = new System.Drawing.Size(108, 22);
            this.txt_UpperBound.TabIndex = 19;
            // 
            // materialSetBox
            // 
            this.materialSetBox.Controls.Add(this.rbAlum);
            this.materialSetBox.Controls.Add(this.rbNickel);
            this.materialSetBox.Controls.Add(this.rbSilicon);
            this.materialSetBox.Location = new System.Drawing.Point(88, 183);
            this.materialSetBox.Name = "materialSetBox";
            this.materialSetBox.Size = new System.Drawing.Size(242, 116);
            this.materialSetBox.TabIndex = 18;
            this.materialSetBox.TabStop = false;
            this.materialSetBox.Text = "Set Material";
            // 
            // rbAlum
            // 
            this.rbAlum.AutoSize = true;
            this.rbAlum.Location = new System.Drawing.Point(23, 70);
            this.rbAlum.Name = "rbAlum";
            this.rbAlum.Size = new System.Drawing.Size(153, 20);
            this.rbAlum.TabIndex = 2;
            this.rbAlum.TabStop = true;
            this.rbAlum.Text = "Aluminium 1060 Alloy";
            this.rbAlum.UseVisualStyleBackColor = true;
            // 
            // rbNickel
            // 
            this.rbNickel.AutoSize = true;
            this.rbNickel.Location = new System.Drawing.Point(151, 32);
            this.rbNickel.Name = "rbNickel";
            this.rbNickel.Size = new System.Drawing.Size(66, 20);
            this.rbNickel.TabIndex = 1;
            this.rbNickel.Text = "Nickel";
            this.rbNickel.UseVisualStyleBackColor = true;
            // 
            // rbSilicon
            // 
            this.rbSilicon.AutoSize = true;
            this.rbSilicon.Checked = true;
            this.rbSilicon.Location = new System.Drawing.Point(23, 32);
            this.rbSilicon.Name = "rbSilicon";
            this.rbSilicon.Size = new System.Drawing.Size(105, 20);
            this.rbSilicon.TabIndex = 0;
            this.rbSilicon.TabStop = true;
            this.rbSilicon.Text = "Silicon (SiO₂)";
            this.rbSilicon.UseVisualStyleBackColor = true;
            // 
            // restraintsCheckBox
            // 
            this.restraintsCheckBox.BackColor = System.Drawing.SystemColors.Info;
            this.restraintsCheckBox.CheckOnClick = true;
            this.restraintsCheckBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.restraintsCheckBox.FormattingEnabled = true;
            this.restraintsCheckBox.Items.AddRange(new object[] {
            "Anchors",
            "Base-Bottom"});
            this.restraintsCheckBox.Location = new System.Drawing.Point(88, 317);
            this.restraintsCheckBox.Name = "restraintsCheckBox";
            this.restraintsCheckBox.Size = new System.Drawing.Size(242, 38);
            this.restraintsCheckBox.TabIndex = 17;
            this.restraintsCheckBox.SelectedIndexChanged += new System.EventHandler(this.restraintsCheckBox_SelectedIndexChanged);
            // 
            // btnFreqSimulation
            // 
            this.btnFreqSimulation.Location = new System.Drawing.Point(88, 375);
            this.btnFreqSimulation.Name = "btnFreqSimulation";
            this.btnFreqSimulation.Size = new System.Drawing.Size(242, 35);
            this.btnFreqSimulation.TabIndex = 16;
            this.btnFreqSimulation.Text = "Run Freq.";
            this.btnFreqSimulation.UseVisualStyleBackColor = true;
            this.btnFreqSimulation.Click += new System.EventHandler(this.btnFreqSimulation_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 61);
            this.label1.TabIndex = 23;
            this.label1.Text = "Frequency Simulation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(415, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 61);
            this.label2.TabIndex = 24;
            this.label2.Text = "Harmonic Simulation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHarmSimulation
            // 
            this.btnHarmSimulation.Enabled = false;
            this.btnHarmSimulation.Location = new System.Drawing.Point(456, 375);
            this.btnHarmSimulation.Name = "btnHarmSimulation";
            this.btnHarmSimulation.Size = new System.Drawing.Size(242, 35);
            this.btnHarmSimulation.TabIndex = 26;
            this.btnHarmSimulation.Text = "Run Harmonic";
            this.btnHarmSimulation.UseVisualStyleBackColor = true;
            this.btnHarmSimulation.Click += new System.EventHandler(this.btnHarmSimulation_Click);
            // 
            // excitationFacesBox
            // 
            this.excitationFacesBox.Controls.Add(this.rbTopFace);
            this.excitationFacesBox.Controls.Add(this.rbBottomFace);
            this.excitationFacesBox.Enabled = false;
            this.excitationFacesBox.Location = new System.Drawing.Point(481, 253);
            this.excitationFacesBox.Name = "excitationFacesBox";
            this.excitationFacesBox.Size = new System.Drawing.Size(196, 98);
            this.excitationFacesBox.TabIndex = 19;
            this.excitationFacesBox.TabStop = false;
            this.excitationFacesBox.Text = "Choose Acceleration Face";
            // 
            // rbTopFace
            // 
            this.rbTopFace.AutoSize = true;
            this.rbTopFace.Location = new System.Drawing.Point(30, 58);
            this.rbTopFace.Name = "rbTopFace";
            this.rbTopFace.Size = new System.Drawing.Size(120, 20);
            this.rbTopFace.TabIndex = 1;
            this.rbTopFace.Text = "Top-Side-Face";
            this.rbTopFace.UseVisualStyleBackColor = true;
            // 
            // rbBottomFace
            // 
            this.rbBottomFace.AutoSize = true;
            this.rbBottomFace.Checked = true;
            this.rbBottomFace.Location = new System.Drawing.Point(30, 32);
            this.rbBottomFace.Name = "rbBottomFace";
            this.rbBottomFace.Size = new System.Drawing.Size(137, 20);
            this.rbBottomFace.TabIndex = 0;
            this.rbBottomFace.TabStop = true;
            this.rbBottomFace.Text = "Bottom-Side-Face";
            this.rbBottomFace.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(595, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Points for each Freq.";
            // 
            // txtHarmNumPoints
            // 
            this.txtHarmNumPoints.Enabled = false;
            this.txtHarmNumPoints.Location = new System.Drawing.Point(598, 142);
            this.txtHarmNumPoints.Name = "txtHarmNumPoints";
            this.txtHarmNumPoints.Size = new System.Drawing.Size(143, 22);
            this.txtHarmNumPoints.TabIndex = 29;
            this.txtHarmNumPoints.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(422, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Num of Modes (Freq.)";
            // 
            // txtHarmNumFreq
            // 
            this.txtHarmNumFreq.Enabled = false;
            this.txtHarmNumFreq.Location = new System.Drawing.Point(425, 142);
            this.txtHarmNumFreq.Name = "txtHarmNumFreq";
            this.txtHarmNumFreq.Size = new System.Drawing.Size(139, 22);
            this.txtHarmNumFreq.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(500, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Expensive Parameters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(513, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Damping (5%-15%)";
            // 
            // txtHarmDamping
            // 
            this.txtHarmDamping.Enabled = false;
            this.txtHarmDamping.Location = new System.Drawing.Point(514, 213);
            this.txtHarmDamping.Name = "txtHarmDamping";
            this.txtHarmDamping.Size = new System.Drawing.Size(135, 22);
            this.txtHarmDamping.TabIndex = 32;
            this.txtHarmDamping.Text = "0,05";
            // 
            // harmonicPrg
            // 
            this.harmonicPrg.Location = new System.Drawing.Point(456, 431);
            this.harmonicPrg.MarqueeAnimationSpeed = 30;
            this.harmonicPrg.Name = "harmonicPrg";
            this.harmonicPrg.Size = new System.Drawing.Size(242, 23);
            this.harmonicPrg.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.harmonicPrg.TabIndex = 6;
            this.harmonicPrg.Visible = false;
            // 
            // freqPrg
            // 
            this.freqPrg.Location = new System.Drawing.Point(88, 431);
            this.freqPrg.MarqueeAnimationSpeed = 30;
            this.freqPrg.Name = "freqPrg";
            this.freqPrg.Size = new System.Drawing.Size(242, 23);
            this.freqPrg.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.freqPrg.TabIndex = 35;
            this.freqPrg.Visible = false;
            // 
            // rbUpperBound
            // 
            this.rbUpperBound.AutoSize = true;
            this.rbUpperBound.Location = new System.Drawing.Point(94, 111);
            this.rbUpperBound.Name = "rbUpperBound";
            this.rbUpperBound.Size = new System.Drawing.Size(108, 20);
            this.rbUpperBound.TabIndex = 36;
            this.rbUpperBound.Text = "Upper Bound";
            this.rbUpperBound.UseVisualStyleBackColor = true;
            this.rbUpperBound.CheckedChanged += new System.EventHandler(this.rbUpperBound_CheckedChanged);
            // 
            // rbNumOfFreq
            // 
            this.rbNumOfFreq.AutoSize = true;
            this.rbNumOfFreq.Checked = true;
            this.rbNumOfFreq.Location = new System.Drawing.Point(222, 111);
            this.rbNumOfFreq.Name = "rbNumOfFreq";
            this.rbNumOfFreq.Size = new System.Drawing.Size(107, 20);
            this.rbNumOfFreq.TabIndex = 37;
            this.rbNumOfFreq.TabStop = true;
            this.rbNumOfFreq.Text = "Num. of Freq.";
            this.rbNumOfFreq.UseVisualStyleBackColor = true;
            this.rbNumOfFreq.CheckedChanged += new System.EventHandler(this.rbNumOfFreq_CheckedChanged);
            // 
            // GyroAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.rbNumOfFreq);
            this.Controls.Add(this.rbUpperBound);
            this.Controls.Add(this.freqPrg);
            this.Controls.Add(this.txt_NumFreq);
            this.Controls.Add(this.harmonicPrg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHarmDamping);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHarmNumPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHarmNumFreq);
            this.Controls.Add(this.excitationFacesBox);
            this.Controls.Add(this.btnHarmSimulation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UpperBound);
            this.Controls.Add(this.materialSetBox);
            this.Controls.Add(this.restraintsCheckBox);
            this.Controls.Add(this.btnFreqSimulation);
            this.Name = "GyroAnalysisForm";
            this.Text = "MEMS-Gyroscope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GyroAnalysisForm_FormClosing);
            this.materialSetBox.ResumeLayout(false);
            this.materialSetBox.PerformLayout();
            this.excitationFacesBox.ResumeLayout(false);
            this.excitationFacesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NumFreq;
        private System.Windows.Forms.TextBox txt_UpperBound;
        private System.Windows.Forms.GroupBox materialSetBox;
        private System.Windows.Forms.RadioButton rbNickel;
        private System.Windows.Forms.RadioButton rbSilicon;
        private System.Windows.Forms.CheckedListBox restraintsCheckBox;
        private System.Windows.Forms.Button btnFreqSimulation;
        private System.Windows.Forms.RadioButton rbAlum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHarmSimulation;
        private System.Windows.Forms.GroupBox excitationFacesBox;
        private System.Windows.Forms.RadioButton rbTopFace;
        private System.Windows.Forms.RadioButton rbBottomFace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHarmNumPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHarmNumFreq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHarmDamping;
        private System.Windows.Forms.ProgressBar harmonicPrg;
        private System.Windows.Forms.ProgressBar freqPrg;
        private System.Windows.Forms.RadioButton rbUpperBound;
        private System.Windows.Forms.RadioButton rbNumOfFreq;
    }
}