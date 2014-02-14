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

        bool EnableEditing = false;
        bool Edited = false;
        string AvatarName;

        public Profile_Edit()
        {
            InitializeComponent();

            loadSettings();
        }

        private void loadSettings()
        {
            /* Settings Data Loading */
            XmlSerializer xs = new XmlSerializer(typeof(Save_Information_Settings));
            FileStream read = new FileStream(SettingsDirectory + SettingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Save_Information_Settings info = (Save_Information_Settings)xs.Deserialize(read);
            SelectedProfile = info.SelectedProfile;

            /*  Make Sure To Stop Reading The File */
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
                this.Text = "Profile Edit | " + SelectedProfile;
                this.Refresh();

                /* Load Player Avatar */
                cmbAvatar.Text = info.ProfileAvatar;
                AvatarName = info.ProfileAvatar;
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

                /*  Make Sure To Stop Reading The File */
                read.Close();

                EnableEditing = true;
            }
        }

        private void saveProfileData()
        {
            if (Edited)
            {
                try
                {
                    Save_Information_Profile info = new Save_Information_Profile();
                    info.ProfileName = txtProfileName.Text;
                    info.ProfileAvatar = cmbAvatar.Text;
                    info.Difficulty = cmbDifficulty.Text;
                    Save_Data.SaveData(info, ProfilesDirectory, txtProfileName.Text + ".xml");

                    MessageBox.Show("Sucessfully edited your profile!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            saveProfileData();
            Edited = false;
        }

        private void checkEdited()
        {
            if (!(cmbAvatar.Text == AvatarName))
            {
                Edited = true;
                cmdSave.Enabled = true;
            }
        }

        private void cmbAvatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnableEditing)
            {
                checkEdited();
            }

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
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnableEditing)
            {
                checkEdited();
            }
        }

        private void Profile_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Edited)
            {
                DialogResult closing = MessageBox.Show("You have made some edits! Do you wish to save your changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (closing == DialogResult.Yes)
                {
                    MessageBox.Show("Saving");
                    saveProfileData();
                }
            }
        }
    }
}