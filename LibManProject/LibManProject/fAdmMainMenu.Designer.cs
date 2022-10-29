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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.butQLQD = new System.Windows.Forms.Button();
            this.butQLS = new System.Windows.Forms.Button();
            this.butQLND = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.butLogout = new System.Windows.Forms.Button();
            this.butAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Controls.Add(this.containerPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 838);
            this.panel1.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.butQLQD);
            this.menuPanel.Controls.Add(this.butQLS);
            this.menuPanel.Controls.Add(this.butQLND);
            this.menuPanel.Controls.Add(this.butHome);
            this.menuPanel.Location = new System.Drawing.Point(3, 89);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(186, 749);
            this.menuPanel.TabIndex = 2;
            // 
            // butQLQD
            // 
            this.butQLQD.BackColor = System.Drawing.Color.Transparent;
            this.butQLQD.FlatAppearance.BorderSize = 0;
            this.butQLQD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQLQD.Location = new System.Drawing.Point(3, 228);
            this.butQLQD.Name = "butQLQD";
            this.butQLQD.Size = new System.Drawing.Size(180, 69);
            this.butQLQD.TabIndex = 0;
            this.butQLQD.Text = "Quản lý quy định";
            this.butQLQD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLQD.UseVisualStyleBackColor = false;
            // 
            // butQLS
            // 
            this.butQLS.BackColor = System.Drawing.Color.Transparent;
            this.butQLS.FlatAppearance.BorderSize = 0;
            this.butQLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQLS.Location = new System.Drawing.Point(3, 153);
            this.butQLS.Name = "butQLS";
            this.butQLS.Size = new System.Drawing.Size(180, 69);
            this.butQLS.TabIndex = 0;
            this.butQLS.Text = "Quản lý sách";
            this.butQLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLS.UseVisualStyleBackColor = false;
            // 
            // butQLND
            // 
            this.butQLND.BackColor = System.Drawing.Color.Transparent;
            this.butQLND.FlatAppearance.BorderSize = 0;
            this.butQLND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQLND.Location = new System.Drawing.Point(3, 78);
            this.butQLND.Name = "butQLND";
            this.butQLND.Size = new System.Drawing.Size(180, 69);
            this.butQLND.TabIndex = 0;
            this.butQLND.Text = "Quản lý người dùng";
            this.butQLND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLND.UseVisualStyleBackColor = false;
            // 
            // butHome
            // 
            this.butHome.BackColor = System.Drawing.Color.Transparent;
            this.butHome.FlatAppearance.BorderSize = 0;
            this.butHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHome.Location = new System.Drawing.Point(3, 3);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(180, 69);
            this.butHome.TabIndex = 0;
            this.butHome.Text = "Trang chủ";
            this.butHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHome.UseVisualStyleBackColor = false;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.containerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.containerPanel.Location = new System.Drawing.Point(196, 90);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1220, 748);
            this.containerPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Controls.Add(this.butLogout);
            this.topPanel.Controls.Add(this.butAccount);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1419, 84);
            this.topPanel.TabIndex = 1;
            // 
            // butLogout
            // 
            this.butLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butLogout.BackColor = System.Drawing.Color.Transparent;
            this.butLogout.FlatAppearance.BorderSize = 0;
            this.butLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogout.Location = new System.Drawing.Point(1322, 8);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(94, 69);
            this.butLogout.TabIndex = 0;
            this.butLogout.Text = "Đăng xuất";
            this.butLogout.UseVisualStyleBackColor = false;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // butAccount
            // 
            this.butAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butAccount.BackColor = System.Drawing.Color.Transparent;
            this.butAccount.FlatAppearance.BorderSize = 0;
            this.butAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAccount.Location = new System.Drawing.Point(1127, 5);
            this.butAccount.Name = "butAccount";
            this.butAccount.Size = new System.Drawing.Size(189, 78);
            this.butAccount.TabIndex = 0;
            this.butAccount.Text = "Acount";
            this.butAccount.UseVisualStyleBackColor = false;
            // 
            // fAdmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAdmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butAccount;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Button butQLQD;
        private System.Windows.Forms.Button butQLS;
        private System.Windows.Forms.Button butQLND;
    }
}