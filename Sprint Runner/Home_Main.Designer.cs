namespace Sprint_Runner
{
    partial class Home_Main
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
            this.cmdCreateNew = new System.Windows.Forms.Button();
            this.cmdProfileEdit = new System.Windows.Forms.Button();
            this.cmdProfileSelect = new System.Windows.Forms.Button();
            this.lblCurrentProfile = new MetroFramework.Controls.MetroLabel();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCreateNew
            // 
            this.cmdCreateNew.Location = new System.Drawing.Point(223, 228);
            this.cmdCreateNew.Name = "cmdCreateNew";
            this.cmdCreateNew.Size = new System.Drawing.Size(120, 23);
            this.cmdCreateNew.TabIndex = 0;
            this.cmdCreateNew.Text = "New Profile";
            this.cmdCreateNew.UseVisualStyleBackColor = true;
            this.cmdCreateNew.Click += new System.EventHandler(this.cmdCreateNew_Click);
            // 
            // cmdProfileEdit
            // 
            this.cmdProfileEdit.Location = new System.Drawing.Point(223, 286);
            this.cmdProfileEdit.Name = "cmdProfileEdit";
            this.cmdProfileEdit.Size = new System.Drawing.Size(120, 23);
            this.cmdProfileEdit.TabIndex = 1;
            this.cmdProfileEdit.Text = "Edit Profile";
            this.cmdProfileEdit.UseVisualStyleBackColor = true;
            this.cmdProfileEdit.Click += new System.EventHandler(this.cmdProfileEdit_Click);
            // 
            // cmdProfileSelect
            // 
            this.cmdProfileSelect.Location = new System.Drawing.Point(223, 257);
            this.cmdProfileSelect.Name = "cmdProfileSelect";
            this.cmdProfileSelect.Size = new System.Drawing.Size(120, 23);
            this.cmdProfileSelect.TabIndex = 2;
            this.cmdProfileSelect.Text = "Select Profile";
            this.cmdProfileSelect.UseVisualStyleBackColor = true;
            this.cmdProfileSelect.Click += new System.EventHandler(this.cmdProfileSelect_Click);
            // 
            // lblCurrentProfile
            // 
            this.lblCurrentProfile.AutoSize = true;
            this.lblCurrentProfile.Location = new System.Drawing.Point(23, 290);
            this.lblCurrentProfile.Name = "lblCurrentProfile";
            this.lblCurrentProfile.Size = new System.Drawing.Size(98, 19);
            this.lblCurrentProfile.TabIndex = 13;
            this.lblCurrentProfile.Text = "Current Profile:";
            // 
            // cmdPlay
            // 
            this.cmdPlay.Enabled = false;
            this.cmdPlay.Location = new System.Drawing.Point(223, 199);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(120, 23);
            this.cmdPlay.TabIndex = 14;
            this.cmdPlay.Text = "Start Game";
            this.cmdPlay.UseVisualStyleBackColor = true;
            // 
            // Home_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(366, 336);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.lblCurrentProfile);
            this.Controls.Add(this.cmdProfileSelect);
            this.Controls.Add(this.cmdProfileEdit);
            this.Controls.Add(this.cmdCreateNew);
            this.MaximizeBox = false;
            this.Name = "Home_Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Sprint Runner V2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateNew;
        private System.Windows.Forms.Button cmdProfileEdit;
        private System.Windows.Forms.Button cmdProfileSelect;
        private MetroFramework.Controls.MetroLabel lblCurrentProfile;
        private System.Windows.Forms.Button cmdPlay;
    }
}

