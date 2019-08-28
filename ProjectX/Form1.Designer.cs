namespace ProjectX
{
    partial class Form1
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
            this.applicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nRCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.householdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicantToolStripMenuItem,
            this.nRCToolStripMenuItem,
            this.householdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1912, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicantToolStripMenuItem
            // 
            this.applicantToolStripMenuItem.Name = "applicantToolStripMenuItem";
            this.applicantToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.applicantToolStripMenuItem.Text = "Applicant";
            this.applicantToolStripMenuItem.Click += new System.EventHandler(this.applicantToolStripMenuItem_Click);
            // 
            // nRCToolStripMenuItem
            // 
            this.nRCToolStripMenuItem.Name = "nRCToolStripMenuItem";
            this.nRCToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.nRCToolStripMenuItem.Text = "NRC";
            this.nRCToolStripMenuItem.Click += new System.EventHandler(this.nRCToolStripMenuItem_Click);
            // 
            // householdToolStripMenuItem
            // 
            this.householdToolStripMenuItem.Name = "householdToolStripMenuItem";
            this.householdToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.householdToolStripMenuItem.Text = "Household";
            this.householdToolStripMenuItem.Click += new System.EventHandler(this.householdToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1912, 1001);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1038);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nRCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem householdToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

