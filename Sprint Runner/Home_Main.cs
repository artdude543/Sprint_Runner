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
using System.Xml.Serialization;

namespace Sprint_Runner
{
    public partial class Home_Main : MetroForm
    {
        string SettingsDirectory = "settings/";
        string SettingsFileName = "settings.xml";
        string ProfilesName;

        public Home_Main()
        {
            InitializeComponent();
            // Load Application Settings
            loadSettings();
        }
        public void loadSettings()
        {
            if (!Directory.Exists(SettingsDirectory))
            {
                Directory.CreateDirectory(SettingsDirectory);
            }
            if (File.Exists(SettingsDirectory + SettingsFileName))
            {
                /* Settings Data Loading */
                XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Settings));
                FileStream read = new FileStream(SettingsDirectory + SettingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Save_Information_Settings info = (Save_Information_Settings)xs.Deserialize(read);
                ProfilesName = info.SelectedProfile;
                read.Close();

                lblCurrentProfile.Text = "Current Profile: " + ProfilesName;
                this.Refresh();
            }
            else
            {
                DialogResult newInstall = MessageBox.Show("Welcome! Would you like to create your profile to get started?", "Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (newInstall == DialogResult.Yes)
                {
                    Profile_Create profileCreate = new Profile_Create(this);
                    profileCreate.ShowDialog();
                }
                else
                {
                    /* Create New Settings File */
                    Save_Information_Settings settings = new Save_Information_Settings();
                    settings.SelectedProfile = "";
                    Save_Data.SaveData(settings, SettingsDirectory, SettingsFileName);
                }
            }
        }
        public void reloadProfile()
        {
            /* Settings Data Loading */
            XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Settings));
            FileStream read = new FileStream(SettingsDirectory + SettingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Save_Information_Settings info = (Save_Information_Settings)xs.Deserialize(read);
            ProfilesName = info.SelectedProfile;
            read.Close();

            lblCurrentProfile.Text = "Current Profile: " + ProfilesName;
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