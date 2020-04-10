namespace VehicleRental
{
    partial class VehicleRegisterForm
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
            this.CancelButtonControl = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.makeYearTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonControl.Location = new System.Drawing.Point(211, 120);
            this.CancelButtonControl.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(100, 28);
            this.CancelButtonControl.TabIndex = 47;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(103, 120);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 46;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(10, 85);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 17);
            this.Label6.TabIndex = 42;
            this.Label6.Text = "Make Year";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 53);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 17);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Manufacturer";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 21);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 17);
            this.Label4.TabIndex = 38;
            this.Label4.Text = "Vehicle Name";
            // 
            // makeYearTextBox
            // 
            this.makeYearTextBox.Location = new System.Drawing.Point(151, 77);
            this.makeYearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.makeYearTextBox.Name = "makeYearTextBox";
            this.makeYearTextBox.Size = new System.Drawing.Size(277, 22);
            this.makeYearTextBox.TabIndex = 43;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(151, 45);
            this.manufacturerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(277, 22);
            this.manufacturerTextBox.TabIndex = 41;
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(151, 13);
            this.vehicleNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(277, 22);
            this.vehicleNameTextBox.TabIndex = 39;
            // 
            // VehicleRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 176);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.makeYearTextBox);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.vehicleNameTextBox);
            this.Name = "VehicleRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VehicleRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button CancelButtonControl;
        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox makeYearTextBox;
        internal System.Windows.Forms.TextBox manufacturerTextBox;
        internal System.Windows.Forms.TextBox vehicleNameTextBox;
    }
}