namespace DiskPlanSim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customAlgoTextbox = new System.Windows.Forms.TextBox();
            this.customAlgo = new System.Windows.Forms.RadioButton();
            this.sampleAlgo3 = new System.Windows.Forms.RadioButton();
            this.sampleAlgo2 = new System.Windows.Forms.RadioButton();
            this.sampleAlgo1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chosenAlgoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simChart = new System.Windows.Forms.PictureBox();
            this.FCFSButton = new System.Windows.Forms.Button();
            this.SSTFButton = new System.Windows.Forms.Button();
            this.SCANButton = new System.Windows.Forms.Button();
            this.LOOKButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customAlgoTextbox);
            this.groupBox1.Controls.Add(this.customAlgo);
            this.groupBox1.Controls.Add(this.sampleAlgo3);
            this.groupBox1.Controls.Add(this.sampleAlgo2);
            this.groupBox1.Controls.Add(this.sampleAlgo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vali või sisesta järjend (kujul 1,10,4,2,12,3,13,2)";
            // 
            // customAlgoTextbox
            // 
            this.customAlgoTextbox.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customAlgoTextbox.Location = new System.Drawing.Point(125, 126);
            this.customAlgoTextbox.Name = "customAlgoTextbox";
            this.customAlgoTextbox.Size = new System.Drawing.Size(260, 25);
            this.customAlgoTextbox.TabIndex = 4;
            this.customAlgoTextbox.Click += new System.EventHandler(this.customAlgoTextbox_Click);
            this.customAlgoTextbox.TextChanged += new System.EventHandler(this.customAlgoTextbox_TextChanged);
            this.customAlgoTextbox.Enter += new System.EventHandler(this.customAlgoTextbox_Enter);
            // 
            // customAlgo
            // 
            this.customAlgo.AutoSize = true;
            this.customAlgo.Location = new System.Drawing.Point(25, 125);
            this.customAlgo.Name = "customAlgo";
            this.customAlgo.Size = new System.Drawing.Size(94, 24);
            this.customAlgo.TabIndex = 3;
            this.customAlgo.TabStop = true;
            this.customAlgo.Text = "Enda oma";
            this.customAlgo.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo3
            // 
            this.sampleAlgo3.AutoSize = true;
            this.sampleAlgo3.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo3.Location = new System.Drawing.Point(25, 95);
            this.sampleAlgo3.Name = "sampleAlgo3";
            this.sampleAlgo3.Size = new System.Drawing.Size(242, 22);
            this.sampleAlgo3.TabIndex = 2;
            this.sampleAlgo3.TabStop = true;
            this.sampleAlgo3.Text = "45,6,16,9,33,28,11,37,49,25";
            this.sampleAlgo3.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo2
            // 
            this.sampleAlgo2.AutoSize = true;
            this.sampleAlgo2.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo2.Location = new System.Drawing.Point(25, 65);
            this.sampleAlgo2.Name = "sampleAlgo2";
            this.sampleAlgo2.Size = new System.Drawing.Size(186, 22);
            this.sampleAlgo2.TabIndex = 1;
            this.sampleAlgo2.TabStop = true;
            this.sampleAlgo2.Text = "1,10,44,2,12,3,13,20";
            this.sampleAlgo2.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo1
            // 
            this.sampleAlgo1.AutoSize = true;
            this.sampleAlgo1.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo1.Location = new System.Drawing.Point(25, 35);
            this.sampleAlgo1.Name = "sampleAlgo1";
            this.sampleAlgo1.Size = new System.Drawing.Size(218, 22);
            this.sampleAlgo1.TabIndex = 0;
            this.sampleAlgo1.TabStop = true;
            this.sampleAlgo1.Text = "2,5,13,29,7,1,18,40,49,4";
            this.sampleAlgo1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algoritmi käivitamiseks tee valik ja klõpsa nupule";
            // 
            // chosenAlgoLabel
            // 
            this.chosenAlgoLabel.AutoSize = true;
            this.chosenAlgoLabel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chosenAlgoLabel.Location = new System.Drawing.Point(12, 278);
            this.chosenAlgoLabel.Name = "chosenAlgoLabel";
            this.chosenAlgoLabel.Size = new System.Drawing.Size(27, 20);
            this.chosenAlgoLabel.TabIndex = 2;
            this.chosenAlgoLabel.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Summaarne teepikkus:";
            // 
            // simChart
            // 
            this.simChart.Location = new System.Drawing.Point(12, 311);
            this.simChart.Name = "simChart";
            this.simChart.Size = new System.Drawing.Size(1004, 312);
            this.simChart.TabIndex = 4;
            this.simChart.TabStop = false;
            // 
            // FCFSButton
            // 
            this.FCFSButton.Location = new System.Drawing.Point(12, 233);
            this.FCFSButton.Name = "FCFSButton";
            this.FCFSButton.Size = new System.Drawing.Size(83, 32);
            this.FCFSButton.TabIndex = 5;
            this.FCFSButton.Text = "FCFS";
            this.FCFSButton.UseVisualStyleBackColor = true;
            this.FCFSButton.Click += new System.EventHandler(this.FCFSButton_Click);
            // 
            // SSTFButton
            // 
            this.SSTFButton.Location = new System.Drawing.Point(111, 233);
            this.SSTFButton.Name = "SSTFButton";
            this.SSTFButton.Size = new System.Drawing.Size(83, 32);
            this.SSTFButton.TabIndex = 6;
            this.SSTFButton.Text = "SSTF";
            this.SSTFButton.UseVisualStyleBackColor = true;
            this.SSTFButton.Click += new System.EventHandler(this.SSTFButton_Click);
            // 
            // SCANButton
            // 
            this.SCANButton.Location = new System.Drawing.Point(210, 233);
            this.SCANButton.Name = "SCANButton";
            this.SCANButton.Size = new System.Drawing.Size(83, 32);
            this.SCANButton.TabIndex = 7;
            this.SCANButton.Text = "SCAN";
            this.SCANButton.UseVisualStyleBackColor = true;
            this.SCANButton.Click += new System.EventHandler(this.SCANButton_Click);
            // 
            // LOOKButton
            // 
            this.LOOKButton.Location = new System.Drawing.Point(310, 233);
            this.LOOKButton.Name = "LOOKButton";
            this.LOOKButton.Size = new System.Drawing.Size(83, 32);
            this.LOOKButton.TabIndex = 8;
            this.LOOKButton.Text = "LOOK";
            this.LOOKButton.UseVisualStyleBackColor = true;
            this.LOOKButton.Click += new System.EventHandler(this.LOOKButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(411, 233);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(83, 32);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Puhasta";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Location = new System.Drawing.Point(237, 278);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(18, 20);
            this.pathLabel.TabIndex = 10;
            this.pathLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 638);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LOOKButton);
            this.Controls.Add(this.SCANButton);
            this.Controls.Add(this.SSTFButton);
            this.Controls.Add(this.FCFSButton);
            this.Controls.Add(this.simChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chosenAlgoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kettapööruste planeerija simulaator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customAlgoTextbox;
        private System.Windows.Forms.RadioButton customAlgo;
        private System.Windows.Forms.RadioButton sampleAlgo3;
        private System.Windows.Forms.RadioButton sampleAlgo2;
        private System.Windows.Forms.RadioButton sampleAlgo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chosenAlgoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox simChart;
        private System.Windows.Forms.Button FCFSButton;
        private System.Windows.Forms.Button SSTFButton;
        private System.Windows.Forms.Button SCANButton;
        private System.Windows.Forms.Button LOOKButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label pathLabel;
    }
}

