namespace RestaurantMangementSystem
{
    partial class FloorPlanForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelFloor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFloor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFloor
            // 
            this.panelFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFloor.Location = new System.Drawing.Point(0, 0);
            this.panelFloor.Name = "panelFloor";
            this.panelFloor.Size = new System.Drawing.Size(1029, 640);
            this.panelFloor.TabIndex = 0;
            this.panelFloor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFloor_Paint);
            // 
            // FloorPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Controls.Add(this.panelFloor);
            this.Name = "FloorPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Floor Plan";
            this.ResumeLayout(false);

        }
    }
}