namespace VehicleRental
{
    partial class VehicleRentDetailForm
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
            this.newRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSerializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retriveDeserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentDetailGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRentToolStripMenuItem,
            this.exportToCSVToolStripMenuItem,
            this.importFromCSVToolStripMenuItem,
            this.saveSerializeToolStripMenuItem,
            this.retriveDeserializeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(160, 536);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newRentToolStripMenuItem
            // 
            this.newRentToolStripMenuItem.Name = "newRentToolStripMenuItem";
            this.newRentToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.newRentToolStripMenuItem.Text = "Rent Car";
            this.newRentToolStripMenuItem.Click += new System.EventHandler(this.newRentToolStripMenuItem_Click);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // importFromCSVToolStripMenuItem
            // 
            this.importFromCSVToolStripMenuItem.Name = "importFromCSVToolStripMenuItem";
            this.importFromCSVToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.importFromCSVToolStripMenuItem.Text = "Import from CSV";
            this.importFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importFromCSVToolStripMenuItem_Click);
            // 
            // saveSerializeToolStripMenuItem
            // 
            this.saveSerializeToolStripMenuItem.Name = "saveSerializeToolStripMenuItem";
            this.saveSerializeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.saveSerializeToolStripMenuItem.Text = "Save(Serialize)";
            this.saveSerializeToolStripMenuItem.Click += new System.EventHandler(this.saveSerializeToolStripMenuItem_Click);
            // 
            // retriveDeserializeToolStripMenuItem
            // 
            this.retriveDeserializeToolStripMenuItem.Name = "retriveDeserializeToolStripMenuItem";
            this.retriveDeserializeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.retriveDeserializeToolStripMenuItem.Text = "Retrive (Deserialize)";
            this.retriveDeserializeToolStripMenuItem.Click += new System.EventHandler(this.retriveDeserializeToolStripMenuItem_Click);
            // 
            // rentDetailGridView
            // 
            this.rentDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentDetailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentDetailGridView.Location = new System.Drawing.Point(160, 0);
            this.rentDetailGridView.Name = "rentDetailGridView";
            this.rentDetailGridView.RowTemplate.Height = 24;
            this.rentDetailGridView.Size = new System.Drawing.Size(792, 536);
            this.rentDetailGridView.TabIndex = 1;
            // 
            // VehicleRentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 536);
            this.Controls.Add(this.rentDetailGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VehicleRentDetailForm";
            this.Text = "VehicleRentDetailForm";
            this.Load += new System.EventHandler(this.VehicleRentDetailForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentDetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSerializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retriveDeserializeToolStripMenuItem;
        private System.Windows.Forms.DataGridView rentDetailGridView;
    }
}