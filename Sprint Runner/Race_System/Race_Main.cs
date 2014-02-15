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
using System.Xml.Serialization;
using System.IO;

namespace Sprint_Runner
{
    public partial class Race_Main : MetroForm
    {
        private readonly Home_Main _Home_Main;

        string SettingsDirectory = "settings/";
        string SettingsFileName = "settings.xml";

        string ProfilesDirectory = "profiles/";

        string SelectedProfile = "";
        string SelectedProfileAvatar = "";
        string Difficulty = "";
        int TotalWins;
        int TotalScore;

        public Race_Main(Home_Main HomeMain)
        {
            InitializeComponent();

            this._Home_Main = HomeMain;
        }

        private void loadRace()
        {
            
        }

        private void loadSettings()
        {
            /* Load SelectedProfile (Current User) */
            XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Settings));
            FileStream read = new FileStream(SettingsDirectory + SettingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Save_Information_Settings info = (Save_Information_Settings)xs.Deserialize(read);
            SelectedProfile = info.SelectedProfile;
            read.Close();

            /* Load Profile Data */
            loadProfile(SelectedProfile);
        }

        private void loadProfile(string currentProfile)
        {
            if (File.Exists(ProfilesDirectory + currentProfile + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Profile));
                FileStream read = new FileStream(ProfilesDirectory + currentProfile + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Save_Information_Profile info = (Save_Information_Profile)xs.Deserialize(read);

                SelectedProfileAvatar = info.ProfileAvatar;
                Difficulty = info.Difficulty;
                TotalScore = info.TotalScore;
                TotalWins = info.TotalWins;
            }
        }

        private void Race_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}