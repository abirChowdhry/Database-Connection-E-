namespace Database_Connection_E_
{
    partial class Dashboard
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
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegistrationToolStripMenuItem,
            this.userListToolStripMenuItem,
            this.userProfileUpdateToolStripMenuItem,
            this.userProfileDeleteToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userRegistrationToolStripMenuItem.Text = "User Registration";
            this.userRegistrationToolStripMenuItem.Click += new System.EventHandler(this.userRegistrationToolStripMenuItem_Click);
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // userProfileUpdateToolStripMenuItem
            // 
            this.userProfileUpdateToolStripMenuItem.Name = "userProfileUpdateToolStripMenuItem";
            this.userProfileUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userProfileUpdateToolStripMenuItem.Text = "User Profile Update";
            this.userProfileUpdateToolStripMenuItem.Click += new System.EventHandler(this.userProfileUpdateToolStripMenuItem_Click);
            // 
            // userProfileDeleteToolStripMenuItem
            // 
            this.userProfileDeleteToolStripMenuItem.Name = "userProfileDeleteToolStripMenuItem";
            this.userProfileDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userProfileDeleteToolStripMenuItem.Text = "User Profile Delete";
            this.userProfileDeleteToolStripMenuItem.Click += new System.EventHandler(this.userProfileDeleteToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 267);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfileUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfileDeleteToolStripMenuItem;
    }
}