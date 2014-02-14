namespace Sprint_Runner
{
    partial class Profile_Select
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
            this.cmdProfiles = new System.Windows.Forms.ComboBox();
            this.lblSelectProfile = new MetroFramework.Controls.MetroLabel();
            this.cmdSelect = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmdProfiles
            // 
            this.cmdProfiles.FormattingEnabled = true;
            this.cmdProfiles.Location = new System.Drawing.Point(148, 83);
            this.cmdProfiles.Name = "cmdProfiles";
            this.cmdProfiles.Size = new System.Drawing.Size(121, 21);
            this.cmdProfiles.TabIndex = 0;
            this.cmdProfiles.SelectedIndexChanged += new System.EventHandler(this.cmdProfiles_SelectedIndexChanged);
            // 
            // lblSelectProfile
            // 
            this.lblSelectProfile.AutoSize = true;
            this.lblSelectProfile.Location = new System.Drawing.Point(23, 83);
            this.lblSelectProfile.Name = "lblSelectProfile";
            this.lblSelectProfile.Size = new System.Drawing.Size(119, 19);
            this.lblSelectProfile.TabIndex = 1;
            this.lblSelectProfile.Text = "Select Your Profile:";
            // 
            // cmdSelect
            // 
            this.cmdSelect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.cmdSelect.Location = new System.Drawing.Point(23, 144);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(75, 23);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Select Profile";
            this.cmdSelect.UseSelectable = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // Profile_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(336, 199);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.lblSelectProfile);
            this.Controls.Add(this.cmdProfiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Profile_Select";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Select Profile |";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdProfiles;
        private MetroFramework.Controls.MetroLabel lblSelectProfile;
        private MetroFramework.Controls.MetroButton cmdSelect;
    }
}