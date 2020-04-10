using System;
using System.Collections.Generic;

namespace VehicleRental
{
    partial class RentCarForm
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
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inTimeLabel = new System.Windows.Forms.Label();
            this.outTImeLabel = new System.Windows.Forms.Label();
            this.outTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.vehicleComboBOx = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inTimePicker
            // 
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.inTimePicker.Location = new System.Drawing.Point(84, 74);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.ShowUpDown = true;
            this.inTimePicker.Size = new System.Drawing.Size(116, 22);
            this.inTimePicker.TabIndex = 0;
            this.inTimePicker.Value = new System.DateTime(2018, 12, 29, 14, 13, 0, 0);
            // 
            // inTimeLabel
            // 
            this.inTimeLabel.AutoSize = true;
            this.inTimeLabel.Location = new System.Drawing.Point(12, 79);
            this.inTimeLabel.Name = "inTimeLabel";
            this.inTimeLabel.Size = new System.Drawing.Size(58, 17);
            this.inTimeLabel.TabIndex = 1;
            this.inTimeLabel.Text = "In Time ";
            // 
            // outTImeLabel
            // 
            this.outTImeLabel.AutoSize = true;
            this.outTImeLabel.Location = new System.Drawing.Point(12, 105);
            this.outTImeLabel.Name = "outTImeLabel";
            this.outTImeLabel.Size = new System.Drawing.Size(66, 17);
            this.outTImeLabel.TabIndex = 2;
            this.outTImeLabel.Text = "Out Time";
            // 
            // outTimeDatePicker
            // 
            this.outTimeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.outTimeDatePicker.Location = new System.Drawing.Point(84, 105);
            this.outTimeDatePicker.Name = "outTimeDatePicker";
            this.outTimeDatePicker.ShowUpDown = true;
            this.outTimeDatePicker.Size = new System.Drawing.Size(116, 22);
            this.outTimeDatePicker.TabIndex = 3;
            this.outTimeDatePicker.Value = new System.DateTime(2018, 12, 29, 14, 13, 0, 0);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(84, 44);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(248, 22);
            this.datePicker.TabIndex = 5;
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Location = new System.Drawing.Point(12, 20);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(54, 17);
            this.vehicleLabel.TabIndex = 6;
            this.vehicleLabel.Text = "Vehicle";
            // 
            // vehicleComboBOx
            // 
            this.vehicleComboBOx.FormattingEnabled = true;
            this.vehicleComboBOx.Location = new System.Drawing.Point(84, 13);
            this.vehicleComboBOx.Name = "vehicleComboBOx";
            this.vehicleComboBOx.Size = new System.Drawing.Size(248, 24);
            this.vehicleComboBOx.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(114, 160);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            RentCarForm rentCarForm = this;
            
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(195, 160);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // RentCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 238);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.vehicleComboBOx);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.outTimeDatePicker);
            this.Controls.Add(this.outTImeLabel);
            this.Controls.Add(this.inTimeLabel);
            this.Controls.Add(this.inTimePicker);
            this.Name = "RentCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RentCarForm";
            this.Load += new System.EventHandler(this.RentCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void okButton_Click(List<Vehicle> vehicles)
        {
            
                //call this method to save the file.
                SerializeVehicleData(vehicles);
            
        }

        #endregion

        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.Label inTimeLabel;
        private System.Windows.Forms.Label outTImeLabel;
        private System.Windows.Forms.DateTimePicker outTimeDatePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.ComboBox vehicleComboBOx;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}