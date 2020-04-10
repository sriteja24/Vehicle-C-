namespace VehicleRental
{
    partial class VehicleDetailForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSerializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveDeserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByMakeYearBubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.importFromCSVToolStripMenuItem,
            this.exportToCSVToolStripMenuItem,
            this.saveSerializeToolStripMenuItem,
            this.retrieveDeserializeToolStripMenuItem,
            this.sortByMakeYearBubbleSortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(222, 450);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.addVehicleToolStripMenuItem.Text = "&Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // importFromCSVToolStripMenuItem
            // 
            this.importFromCSVToolStripMenuItem.Name = "importFromCSVToolStripMenuItem";
            this.importFromCSVToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.importFromCSVToolStripMenuItem.Text = "&Import From CSV";
            this.importFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importVehicle_Click);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.exportToCSVToolStripMenuItem.Text = "&Export To CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportVehicleDialog_Click);
            // 
            // saveSerializeToolStripMenuItem
            // 
            this.saveSerializeToolStripMenuItem.Name = "saveSerializeToolStripMenuItem";
            this.saveSerializeToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.saveSerializeToolStripMenuItem.Text = "&Save (Serialize)";
            this.saveSerializeToolStripMenuItem.Click += new System.EventHandler(this.saveSerializeToolStripMenuItem_Click);
            // 
            // retrieveDeserializeToolStripMenuItem
            // 
            this.retrieveDeserializeToolStripMenuItem.Name = "retrieveDeserializeToolStripMenuItem";
            this.retrieveDeserializeToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.retrieveDeserializeToolStripMenuItem.Text = "&Retrieve (Deserialize)";
            this.retrieveDeserializeToolStripMenuItem.Click += new System.EventHandler(this.retrieveDeserializeToolStripMenuItem_Click);
            // 
            // sortByMakeYearBubbleSortToolStripMenuItem
            // 
            this.sortByMakeYearBubbleSortToolStripMenuItem.Name = "sortByMakeYearBubbleSortToolStripMenuItem";
            this.sortByMakeYearBubbleSortToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.sortByMakeYearBubbleSortToolStripMenuItem.Text = "SortByMakeYear (BubbleSort)";
            this.sortByMakeYearBubbleSortToolStripMenuItem.Click += new System.EventHandler(this.sortByMakeYearBubbleSortToolStripMenuItem_Click);
            // 
            // vehicleListGridView
            // 
            this.vehicleListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleListGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleListGridView.Location = new System.Drawing.Point(222, 0);
            this.vehicleListGridView.Name = "vehicleListGridView";
            this.vehicleListGridView.RowTemplate.Height = 24;
            this.vehicleListGridView.Size = new System.Drawing.Size(578, 450);
            this.vehicleListGridView.TabIndex = 63;
            // 
            // VehicleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehicleListGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VehicleDetailForm";
            this.Text = "VehicleDetailForm";
            this.Load += new System.EventHandler(this.VehicleDetailForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.DataGridView vehicleListGridView;
        private System.Windows.Forms.ToolStripMenuItem importFromCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSerializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveDeserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByMakeYearBubbleSortToolStripMenuItem;
    }
}