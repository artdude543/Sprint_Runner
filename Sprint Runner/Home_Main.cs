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

            /* Load Application Settings */
            loadSettings();
        }
        public void loadSettings()
        {
            /* If Settings Directory Not Exists Create One */
            if (!Directory.Exists(SettingsDirectory))
            {
                Directory.CreateDirectory(SettingsDirectory);
            }

            /* If Settings Directory Does Exists Continue Loading Settings */
            if (File.Exists(SettingsDirectory + SettingsFileName))
            {
                /* Settings Data Loading */
                XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Settings));
                FileStream read = new FileStream(SettingsDirectory + SettingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Save_Information_Settings info = (Save_Information_Settings)xs.Deserialize(read);
                ProfilesName = info.SelectedProfile;
                read.Close();

                /* Set Label As Current User And Enable 'cmdPlay' Button */
                lblCurrentProfile.Text = "Current Profile: " + ProfilesName;
                cmdPlay.Enabled = true;

                /* Bug Is MetroFrameWork Force Refresh The Form */
                this.Refresh();
            }
            else
            {
                DialogResult newInstall = MessageBox.Show("Welcome! Would you like to create your profile to get started?", "Welcome to Sprint Runner", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (newInstall == DialogResult.Yes)
                {
                    /* Show 'Profile_Create' Form To Enable User To Make A Profile */
                    Profile_Create profileCreate = new Profile_Create(this);
                    profileCreate.ShowDialog();
                }
                else
                {
                    /* Create New Settings File */
                    Save_Information_Settings settings = new Save_Information_Settings();
                    settings.SelectedProfile = "";
                    Save_Data.SaveData(settings, SettingsDirectory, SettingsFileName);

                    /* Reload The Profile (Ensure That The Profile Is Loaded And Current Selected) */
                    reloadProfile();
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

            /* If No Profile Is Selected Disable The 'cmdPlay' Button */
            if (ProfilesName == "")
            {
                cmdPlay.Enabled = false;
            }
             
            /* Bug Is MetroFrameWork Force Refresh The Form */
            this.Refresh();
        }

        private void cmdCreateNew_Click(object sender, EventArgs e)
        {
            /* Show 'Profile_Create' Form */
            Profile_Create profileCreate = new Profile_Create(this);
            profileCreate.ShowDialog();
        }

        private void cmdProfileEdit_Click(object sender, EventArgs e)
        {
            /* Show 'Profile_Edit' Form */
            new Profile_Edit().ShowDialog();
        }

        private void cmdProfileSelect_Click(object sender, EventArgs e)
        {
            /* Show 'Profile_Select' Form */
            Profile_Select profileSelect = new Profile_Select(this);
            profileSelect.ShowDialog();
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            Race_Main raceMain = new Race_Main(this);
            raceMain.Show();
            this.Hide();
        }

        private void Home_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}