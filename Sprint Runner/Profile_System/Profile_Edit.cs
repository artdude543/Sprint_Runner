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
        string Difficulty;

        public Profile_Edit()
        {
            InitializeComponent();

            /* Load Settings / Profile */
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
                /* Show MessageBox If No Profile Is Selected/Loaded */
                MessageBox.Show("No Profile Selected!");
            }
            else
            {
                /* Load Profile Data */
                loadProfileData();
            }
        }

        private void loadProfileData()
        {
            /* Double Check That The Profile Exists And Then Open It */
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

                /* Load Player Difficulty */
                cmbDifficulty.Text = info.Difficulty;
                Difficulty = info.Difficulty;

                /*  Make Sure To Stop Reading The File + Make Editing 'True' */
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
                    /* Save New Data To The User Profile */
                    Save_Information_Profile info = new Save_Information_Profile();
                    info.ProfileName = txtProfileName.Text;
                    info.ProfileAvatar = cmbAvatar.Text;
                    info.Difficulty = cmbDifficulty.Text;
                    Save_Data.SaveData(info, ProfilesDirectory, txtProfileName.Text + ".xml");

                    /* Show MessageBox + Change Edited To 'False' */
                    MessageBox.Show("Sucessfully edited your profile!");
                    Edited = false;

                    /* Close This Form */
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
            /* Save Profile Data + Set Edited To 'False' */
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
            else if (!(cmbDifficulty.Text == Difficulty))
            {
                Edited = true;
                cmdSave.Enabled = true;
            }
            else
            {
                Edited = false;
                cmdSave.Enabled = false;
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
            /* Checks If Editing Is Enabled And If Changed Run 'checkEdited()' Function */
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