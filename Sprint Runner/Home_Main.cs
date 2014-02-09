using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Sprint_Runner
{
    public partial class Home_Main : MetroForm
    {
        string ProfileName = Properties.Settings.Default.ProfileName;
        bool ProfileSet = Properties.Settings.Default.ProfileSet;

        public Home_Main()
        {
            InitializeComponent();
            // Load Application Settings
            loadSettings();
        }
        public void loadSettings()
        {
            lblCurrentProfile.Text = lblCurrentProfile.Text + " " + ProfileName;
            if (ProfileSet)
            {
                cmdProfileEdit.Enabled = true;
            }
            else
            {
                cmdProfileEdit.Enabled = false;
            }
        }
        public void reloadProfile()
        {
            ProfileName = Properties.Settings.Default.ProfileName;
            ProfileSet = Properties.Settings.Default.ProfileSet;
            lblCurrentProfile.Text = "Current Profile: " + ProfileName;
            if (ProfileSet)
            {
                cmdProfileEdit.Enabled = true;
            }
            else
            {
                cmdProfileEdit.Enabled = false;
            }
            this.Refresh();
        }

        private void cmdCreateNew_Click(object sender, EventArgs e)
        {
            Profile_Create profileCreate = new Profile_Create(this);
            profileCreate.ShowDialog();
        }

        private void cmdProfileEdit_Click(object sender, EventArgs e)
        {
            new Profile_Edit().ShowDialog();
        }

        private void cmdProfileSelect_Click(object sender, EventArgs e)
        {
            Profile_Select profileSelect = new Profile_Select(this);
            profileSelect.ShowDialog();
        }
    }
}