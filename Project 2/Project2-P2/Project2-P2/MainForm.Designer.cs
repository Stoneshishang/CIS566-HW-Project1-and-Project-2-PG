namespace Project2_P2
{
    partial class MainForm
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
            this.tbKilometers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConvertedLength = new System.Windows.Forms.TextBox();
            this.dlUnits = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbKilometers
            // 
            this.tbKilometers.Location = new System.Drawing.Point(13, 13);
            this.tbKilometers.Name = "tbKilometers";
            this.tbKilometers.Size = new System.Drawing.Size(100, 20);
            this.tbKilometers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kilometers";
            // 
            // tbConvertedLength
            // 
            this.tbConvertedLength.Enabled = false;
            this.tbConvertedLength.Location = new System.Drawing.Point(13, 51);
            this.tbConvertedLength.Name = "tbConvertedLength";
            this.tbConvertedLength.Size = new System.Drawing.Size(100, 20);
            this.tbConvertedLength.TabIndex = 2;
            // 
            // dlUnits
            // 
            this.dlUnits.FormattingEnabled = true;
            this.dlUnits.Items.AddRange(new object[] {
            "Miles",
            "Yards",
            "Feet"});
            this.dlUnits.Location = new System.Drawing.Point(122, 51);
            this.dlUnits.Name = "dlUnits";
            this.dlUnits.Size = new System.Drawing.Size(85, 21);
            this.dlUnits.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 102);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 137);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.dlUnits);
            this.Controls.Add(this.tbConvertedLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKilometers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Length Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKilometers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConvertedLength;
        private System.Windows.Forms.ComboBox dlUnits;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
    }
}

