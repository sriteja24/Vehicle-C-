namespace VehicleRental
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vechicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vechicleToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vechicleToolStripMenuItem
            // 
            this.vechicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem});
            this.vechicleToolStripMenuItem.Name = "vechicleToolStripMenuItem";
            this.vechicleToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.vechicleToolStripMenuItem.Text = "&Vehicle";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.detailToolStripMenuItem.Text = "&Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem1});
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.rentToolStripMenuItem.Text = "&Rent";
            // 
            // detailToolStripMenuItem1
            // 
            this.detailToolStripMenuItem1.Name = "detailToolStripMenuItem1";
            this.detailToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.detailToolStripMenuItem1.Text = "&Detail";
            this.detailToolStripMenuItem1.Click += new System.EventHandler(this.detailToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // rentReportToolStripMenuItem
            // 
            this.rentReportToolStripMenuItem.Name = "rentReportToolStripMenuItem";
            this.rentReportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rentReportToolStripMenuItem.Text = "Weekly Chart";
            this.rentReportToolStripMenuItem.Click += new System.EventHandler(this.rentReportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 694);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vechicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentReportToolStripMenuItem;
    }
}

