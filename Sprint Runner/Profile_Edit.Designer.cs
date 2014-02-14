namespace Sprint_Runner
{
    partial class Profile_Edit
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
            this.lblAvatarPreview = new MetroFramework.Controls.MetroLabel();
            this.picAvatarPreview = new System.Windows.Forms.PictureBox();
            this.cmbAvatar = new System.Windows.Forms.ComboBox();
            this.lblAvatar = new MetroFramework.Controls.MetroLabel();
            this.lblDifficulty = new MetroFramework.Controls.MetroLabel();
            this.lblProfileName = new MetroFramework.Controls.MetroLabel();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.txtProfileName = new MetroFramework.Controls.MetroTextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvatarPreview
            // 
            this.lblAvatarPreview.AutoSize = true;
            this.lblAvatarPreview.Location = new System.Drawing.Point(119, 110);
            this.lblAvatarPreview.Name = "lblAvatarPreview";
            this.lblAvatarPreview.Size = new System.Drawing.Size(57, 19);
            this.lblAvatarPreview.TabIndex = 17;
            this.lblAvatarPreview.Text = "Preview:";
            // 
            // picAvatarPreview
            // 
            this.picAvatarPreview.Location = new System.Drawing.Point(186, 110);
            this.picAvatarPreview.Name = "picAvatarPreview";
            this.picAvatarPreview.Size = new System.Drawing.Size(64, 64);
            this.picAvatarPreview.TabIndex = 16;
            this.picAvatarPreview.TabStop = false;
            // 
            // cmbAvatar
            // 
            this.cmbAvatar.FormattingEnabled = true;
            this.cmbAvatar.Items.AddRange(new object[] {
            "Mario",
            "Mushroom",
            "Mushroom 1UP",
            "Mushroom Super",
            "Block Question"});
            this.cmbAvatar.Location = new System.Drawing.Point(119, 86);
            this.cmbAvatar.Name = "cmbAvatar";
            this.cmbAvatar.Size = new System.Drawing.Size(131, 21);
            this.cmbAvatar.TabIndex = 15;
            this.cmbAvatar.SelectedIndexChanged += new System.EventHandler(this.cmbAvatar_SelectedIndexChanged);
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(62, 88);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(51, 19);
            this.lblAvatar.TabIndex = 14;
            this.lblAvatar.Text = "Avatar:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(52, 182);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(61, 19);
            this.lblDifficulty.TabIndex = 13;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(23, 60);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(90, 19);
            this.lblProfileName.TabIndex = 12;
            this.lblProfileName.Text = "Profile Name:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Pro"});
            this.cmbDifficulty.Location = new System.Drawing.Point(119, 180);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(131, 21);
            this.cmbDifficulty.TabIndex = 11;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(119, 60);
            this.txtProfileName.MaxLength = 32767;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.PasswordChar = '\0';
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfileName.SelectedText = "";
            this.txtProfileName.Size = new System.Drawing.Size(131, 20);
            this.txtProfileName.TabIndex = 10;
            this.txtProfileName.UseSelectable = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(238, 270);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 18;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Profile_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(336, 316);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblAvatarPreview);
            this.Controls.Add(this.picAvatarPreview);
            this.Controls.Add(this.cmbAvatar);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.txtProfileName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Profile_Edit";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Profile Edit |";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_Edit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAvatarPreview;
        private System.Windows.Forms.PictureBox picAvatarPreview;
        private System.Windows.Forms.ComboBox cmbAvatar;
        private MetroFramework.Controls.MetroLabel lblAvatar;
        private MetroFramework.Controls.MetroLabel lblDifficulty;
        private MetroFramework.Controls.MetroLabel lblProfileName;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private MetroFramework.Controls.MetroTextBox txtProfileName;
        private System.Windows.Forms.Button cmdSave;

    }
}