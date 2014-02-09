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
using System.IO;

namespace Sprint_Runner
{
    public partial class Profile_Select : MetroForm
    {
        string profilesDirectory = "profiles/";
        string selectedProfile = "";

        public Profile_Select()
        {
            InitializeComponent();
            loadProfiles();
        }

        private void loadProfiles()
        {
            DirectoryInfo dir = new DirectoryInfo(profilesDirectory);
            FileInfo[] fileList = dir.GetFiles("*.xml", SearchOption.AllDirectories);

            foreach(FileInfo file in fileList)
            {
                cmdProfiles.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        #region Button Functions

        private void cmdProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Select Profile | " + cmdProfiles.Text;
            selectedProfile = cmdProfiles.Text;
            this.Refresh();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected - " + selectedProfile + "'s profile");
        }

        #endregion
    }
}
