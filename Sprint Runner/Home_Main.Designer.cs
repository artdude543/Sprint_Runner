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
            this.cmdTemp = new System.Windows.Forms.Button();
            this.cmdProfileEdit = new System.Windows.Forms.Button();
            this.cmdProfileSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTemp
            // 
            this.cmdTemp.Location = new System.Drawing.Point(153, 138);
            this.cmdTemp.Name = "cmdTemp";
            this.cmdTemp.Size = new System.Drawing.Size(120, 23);
            this.cmdTemp.TabIndex = 0;
            this.cmdTemp.Text = "Create Profile";
            this.cmdTemp.UseVisualStyleBackColor = true;
            this.cmdTemp.Click += new System.EventHandler(this.cmdTemp_Click);
            // 
            // cmdProfileEdit
            // 
            this.cmdProfileEdit.Location = new System.Drawing.Point(153, 167);
            this.cmdProfileEdit.Name = "cmdProfileEdit";
            this.cmdProfileEdit.Size = new System.Drawing.Size(120, 23);
            this.cmdProfileEdit.TabIndex = 1;
            this.cmdProfileEdit.Text = "Edit Profile";
            this.cmdProfileEdit.UseVisualStyleBackColor = true;
            this.cmdProfileEdit.Click += new System.EventHandler(this.cmdProfileEdit_Click);
            // 
            // cmdProfileSelect
            // 
            this.cmdProfileSelect.Location = new System.Drawing.Point(153, 196);
            this.cmdProfileSelect.Name = "cmdProfileSelect";
            this.cmdProfileSelect.Size = new System.Drawing.Size(120, 23);
            this.cmdProfileSelect.TabIndex = 2;
            this.cmdProfileSelect.Text = "Select Profile";
            this.cmdProfileSelect.UseVisualStyleBackColor = true;
            this.cmdProfileSelect.Click += new System.EventHandler(this.cmdProfileSelect_Click);
            // 
            // Home_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(416, 331);
            this.Controls.Add(this.cmdProfileSelect);
            this.Controls.Add(this.cmdProfileEdit);
            this.Controls.Add(this.cmdTemp);
            this.MaximizeBox = false;
            this.Name = "Home_Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Sprint Runner V2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdTemp;
        private System.Windows.Forms.Button cmdProfileEdit;
        private System.Windows.Forms.Button cmdProfileSelect;
    }
}

