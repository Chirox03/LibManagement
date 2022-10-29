namespace LibManProject
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butLogin = new System.Windows.Forms.Button();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUserpwd = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.panel1);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1062, 653);
            this.parentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.butLogin);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtUserpwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 650);
            this.panel1.TabIndex = 0;
            // 
            // butLogin
            // 
            this.butLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.Location = new System.Drawing.Point(472, 406);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(119, 45);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.Gray;
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUsername.BorderRadius = 1;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = null;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(370, 235);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            stateProperties9.BorderColor = System.Drawing.Color.Gray;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnIdleState = stateProperties12;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsername.PlaceholderText = "username";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(323, 44);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextMarginLeft = 3;
            this.txtUsername.TextMarginTop = 0;
            this.txtUsername.TextPlaceholder = "username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WordWrap = true;
            // 
            // txtUserpwd
            // 
            this.txtUserpwd.AcceptsReturn = false;
            this.txtUserpwd.AcceptsTab = false;
            this.txtUserpwd.AnimationSpeed = 200;
            this.txtUserpwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserpwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserpwd.BackColor = System.Drawing.Color.White;
            this.txtUserpwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUserpwd.BackgroundImage")));
            this.txtUserpwd.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUserpwd.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUserpwd.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUserpwd.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUserpwd.BorderRadius = 1;
            this.txtUserpwd.BorderThickness = 1;
            this.txtUserpwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUserpwd.DefaultText = "";
            this.txtUserpwd.FillColor = System.Drawing.Color.White;
            this.txtUserpwd.HideSelection = true;
            this.txtUserpwd.IconLeft = null;
            this.txtUserpwd.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.IconPadding = 10;
            this.txtUserpwd.IconRight = null;
            this.txtUserpwd.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.Lines = new string[0];
            this.txtUserpwd.Location = new System.Drawing.Point(370, 317);
            this.txtUserpwd.MaxLength = 32767;
            this.txtUserpwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUserpwd.Modified = false;
            this.txtUserpwd.Multiline = false;
            this.txtUserpwd.Name = "txtUserpwd";
            stateProperties13.BorderColor = System.Drawing.Color.Gray;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUserpwd.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserpwd.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUserpwd.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUserpwd.OnIdleState = stateProperties16;
            this.txtUserpwd.Padding = new System.Windows.Forms.Padding(3);
            this.txtUserpwd.PasswordChar = '●';
            this.txtUserpwd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUserpwd.PlaceholderText = "password";
            this.txtUserpwd.ReadOnly = false;
            this.txtUserpwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserpwd.SelectedText = "";
            this.txtUserpwd.SelectionLength = 0;
            this.txtUserpwd.SelectionStart = 0;
            this.txtUserpwd.ShortcutsEnabled = true;
            this.txtUserpwd.Size = new System.Drawing.Size(323, 43);
            this.txtUserpwd.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtUserpwd.TabIndex = 1;
            this.txtUserpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserpwd.TextMarginBottom = 0;
            this.txtUserpwd.TextMarginLeft = 3;
            this.txtUserpwd.TextMarginTop = 0;
            this.txtUserpwd.TextPlaceholder = "password";
            this.txtUserpwd.UseSystemPasswordChar = true;
            this.txtUserpwd.WordWrap = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.parentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.parentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private string username;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLogin;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private Bunifu.UI.WinForms.BunifuTextBox txtUserpwd;

        public string Username { get => username; set => username = value; }
    }
}

