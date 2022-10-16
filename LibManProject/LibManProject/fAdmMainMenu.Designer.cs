namespace LibManProject
{
    partial class fAdmMainMenu
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
            this.butAccount = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.butUserManag = new System.Windows.Forms.Button();
            this.butLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butAccount
            // 
            this.butAccount.Location = new System.Drawing.Point(0, 0);
            this.butAccount.Name = "butAccount";
            this.butAccount.Size = new System.Drawing.Size(183, 60);
            this.butAccount.TabIndex = 0;
            this.butAccount.Text = "Account";
            this.butAccount.UseVisualStyleBackColor = true;
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(0, 60);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(183, 60);
            this.butHome.TabIndex = 0;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            // 
            // butUserManag
            // 
            this.butUserManag.Location = new System.Drawing.Point(0, 120);
            this.butUserManag.Name = "butUserManag";
            this.butUserManag.Size = new System.Drawing.Size(183, 60);
            this.butUserManag.TabIndex = 0;
            this.butUserManag.Text = "Users Management";
            this.butUserManag.UseVisualStyleBackColor = true;
            // 
            // butLogout
            // 
            this.butLogout.Location = new System.Drawing.Point(3, 570);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(177, 60);
            this.butLogout.TabIndex = 0;
            this.butLogout.Text = "Logout";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.butLogout);
            this.panel1.Controls.Add(this.butSettings);
            this.panel1.Controls.Add(this.butUserManag);
            this.panel1.Controls.Add(this.butHome);
            this.panel1.Controls.Add(this.butAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 633);
            this.panel1.TabIndex = 0;
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(0, 180);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(183, 60);
            this.butSettings.TabIndex = 0;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            // 
            // fAdmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fAdmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAccount;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butUserManag;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butSettings;
    }
}