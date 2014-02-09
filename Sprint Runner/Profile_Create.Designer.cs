namespace Sprint_Runner
{
    partial class Profile_Create
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
            this.txtProfileName = new MetroFramework.Controls.MetroTextBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblProfileName = new MetroFramework.Controls.MetroLabel();
            this.lblDifficulty = new MetroFramework.Controls.MetroLabel();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.lblAvatar = new MetroFramework.Controls.MetroLabel();
            this.cmbAvatar = new System.Windows.Forms.ComboBox();
            this.picAvatarPreview = new System.Windows.Forms.PictureBox();
            this.lblAvatarPreview = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(119, 60);
            this.txtProfileName.MaxLength = 32767;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.PasswordChar = '\0';
            this.txtProfileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfileName.SelectedText = "";
            this.txtProfileName.Size = new System.Drawing.Size(131, 20);
            this.txtProfileName.TabIndex = 0;
            this.txtProfileName.UseSelectable = true;
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
            this.cmbDifficulty.TabIndex = 2;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(23, 60);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(90, 19);
            this.lblProfileName.TabIndex = 3;
            this.lblProfileName.Text = "Profile Name:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(52, 182);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(61, 19);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(163, 270);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(87, 23);
            this.cmdCreate.TabIndex = 5;
            this.cmdCreate.Text = "Create Profile";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(62, 88);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(51, 19);
            this.lblAvatar.TabIndex = 6;
            this.lblAvatar.Text = "Avatar:";
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
            this.cmbAvatar.TabIndex = 7;
            this.cmbAvatar.SelectedIndexChanged += new System.EventHandler(this.cmbAvatar_SelectedIndexChanged);
            // 
            // picAvatarPreview
            // 
            this.picAvatarPreview.Location = new System.Drawing.Point(186, 110);
            this.picAvatarPreview.Name = "picAvatarPreview";
            this.picAvatarPreview.Size = new System.Drawing.Size(64, 64);
            this.picAvatarPreview.TabIndex = 8;
            this.picAvatarPreview.TabStop = false;
            // 
            // lblAvatarPreview
            // 
            this.lblAvatarPreview.AutoSize = true;
            this.lblAvatarPreview.Location = new System.Drawing.Point(119, 110);
            this.lblAvatarPreview.Name = "lblAvatarPreview";
            this.lblAvatarPreview.Size = new System.Drawing.Size(57, 19);
            this.lblAvatarPreview.TabIndex = 9;
            this.lblAvatarPreview.Text = "Preview:";
            // 
            // Profile_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(336, 316);
            this.Controls.Add(this.lblAvatarPreview);
            this.Controls.Add(this.picAvatarPreview);
            this.Controls.Add(this.cmbAvatar);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.txtProfileName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Profile_Create";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Create Profile |";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtProfileName;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private MetroFramework.Controls.MetroLabel lblProfileName;
        private MetroFramework.Controls.MetroLabel lblDifficulty;
        private System.Windows.Forms.Button cmdCreate;
        private MetroFramework.Controls.MetroLabel lblAvatar;
        private System.Windows.Forms.ComboBox cmbAvatar;
        private System.Windows.Forms.PictureBox picAvatarPreview;
        private MetroFramework.Controls.MetroLabel lblAvatarPreview;

    }
}