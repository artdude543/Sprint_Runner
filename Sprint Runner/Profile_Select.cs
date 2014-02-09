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
        private readonly Home_Main _Home_Main;

        string SettingsDirectory = "settings/";
        string SettingsFileName = "settings.xml";

        string profilesDirectory = "profiles/";
        string selectedProfile = "";

        public Profile_Select(Home_Main HomeMain)
        {
            InitializeComponent();
            this._Home_Main = HomeMain;

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

        private void cmdProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Select Profile | " + cmdProfiles.Text;
            selectedProfile = cmdProfiles.Text;
            this.Refresh();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (cmdProfiles.Text == "")
            {
                DialogResult noProfile = MessageBox.Show("You have not selected a profile! Do you wish to select one now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (noProfile == DialogResult.Yes)
                {
                    cmdProfiles.Focus();
                }
                else
                {
                    /* Create New Settings File (Using False Data) */
                    Save_Information_Settings settings = new Save_Information_Settings();
                    settings.SelectedProfile = "";
                    Save_Data.SaveData(settings, SettingsDirectory, SettingsFileName);

                    this._Home_Main.reloadProfile();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You have selected - " + selectedProfile + "'s profile");

                /* Settings Data Saving */
                Save_Information_Settings settings = new Save_Information_Settings();
                settings.SelectedProfile = selectedProfile;
                Save_Data.SaveData(settings, SettingsDirectory, SettingsFileName);

                this._Home_Main.reloadProfile();
                this.Close();
            }
        }
    }
}