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
    public partial class Profile_Edit : MetroForm
    {
        string SettingsDirectory = "settings/";
        string SettingsFileName = "settings.xml";

        string ProfilesDirectory = "profiles/";
        string SelectedProfile = "";

        public Profile_Edit()
        {
            InitializeComponent();

            loadSettings();
        }

        private void Profile_Edit_Load(object sender, EventArgs e)
        {

        }

        private void loadSettings()
        {
            /* Settings Data Loading */
            XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Settings));
            FileStream read = new FileStream(SettingsDirectory + SettingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Save_Information_Settings info = (Save_Information_Settings)xs.Deserialize(read);
            SelectedProfile = info.SelectedProfile;
            read.Close();
            if (SelectedProfile == "")
            {
                MessageBox.Show("No Profile Selected!");
            }
            else
            {
                loadProfileData();
            }
        }

        private void loadProfileData()
        {
            if (File.Exists(ProfilesDirectory + SelectedProfile + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Profile));
                FileStream read = new FileStream(ProfilesDirectory + SelectedProfile + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Save_Information_Profile info = (Save_Information_Profile)xs.Deserialize(read);

                /* Load Player Information */
                txtProfileName.Text = info.ProfileName;

                /* Load Player Avatar (Need to find a better way of doing this) */
                cmbAvatar.Text = info.ProfileAvatar;
                if (cmbAvatar.Text == "Mario")
                {
                    picAvatarPreview.Image = Properties.Resources.Mario;
                }
                else if (cmbAvatar.Text == "Mushroom")
                {
                    picAvatarPreview.Image = Properties.Resources.Mushroom;
                }
                else if (cmbAvatar.Text == "Mushroom 1UP")
                {
                    picAvatarPreview.Image = Properties.Resources.Mushroom_1UP;
                }
                else if (cmbAvatar.Text == "Mushroom Super")
                {
                    picAvatarPreview.Image = Properties.Resources.Mushroom_Super;
                }
                else if (cmbAvatar.Text == "Block Question")
                {
                    picAvatarPreview.Image = Properties.Resources.Block_Question;
                }
                cmbDifficulty.Text = info.Difficulty;
            }
        }
    }
}