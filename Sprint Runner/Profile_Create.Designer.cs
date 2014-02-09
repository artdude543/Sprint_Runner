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
            this.cmdSave = new MetroFramework.Controls.MetroButton();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(54, 83);
            this.txtProfileName.MaxLength = 32767;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.PasswordChar = '\0';
            this.txtProfileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfileName.SelectedText = "";
            this.txtProfileName.Size = new System.Drawing.Size(131, 20);
            this.txtProfileName.TabIndex = 0;
            this.txtProfileName.UseSelectable = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(39, 239);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "button1";
            this.cmdSave.UseSelectable = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Pro"});
            this.cmbDifficulty.Location = new System.Drawing.Point(54, 109);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(131, 21);
            this.cmbDifficulty.TabIndex = 2;
            // 
            // Profile_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(336, 316);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.cmdSave);
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtProfileName;
        private MetroFramework.Controls.MetroButton cmdSave;
        private System.Windows.Forms.ComboBox cmbDifficulty;

    }
}