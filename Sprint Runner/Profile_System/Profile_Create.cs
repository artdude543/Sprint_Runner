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
    public partial class Profile_Create : MetroForm
    {
        private readonly Home_Main _Home_Main;

        string SettingsDirectory = "settings/";
        string SettingsFileName = "settings.xml";

        string profilesDirectory = "profiles/";
        bool error = false;
        string errorMessage = "";

        public Profile_Create(Home_Main HomeMain)
        {
            InitializeComponent();
            
            this._Home_Main = HomeMain;
        }

        private void cmbAvatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAvatar.Text == "Mario")
            {
                picAvatarPreview.Image = Properties.Resources.Mario;
            }
            else if(cmbAvatar.Text == "Mushroom")
            {
                picAvatarPreview.Image = Properties.Resources.Mushroom;
            }
            else if(cmbAvatar.Text == "Mushroom 1UP")
            {
                picAvatarPreview.Image = Properties.Resources.Mushroom_1UP;
            }
            else if(cmbAvatar.Text == "Mushroom Super")
            {
                picAvatarPreview.Image = Properties.Resources.Mushroom_Super;
            }
            else if(cmbAvatar.Text == "Block Question")
            {
                picAvatarPreview.Image = Properties.Resources.Block_Question;
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (txtProfileName.Text == "")
            {
                error = true;
                errorMessage = "Profile Name Not Entered!";
            }
            else if (cmbAvatar.Text == "")
            {
                error = true;
                errorMessage = "Avatar Not Set!";
            }
            else if (cmbDifficulty.Text == "")
            {
                error = true;
                errorMessage = "Difficulty Not Set!";
            }
            if (!error)
            {
                try
                {
                    if (File.Exists(profilesDirectory + txtProfileName.Text + ".xml"))
                    {
                        MessageBox.Show("Profile Save '" + txtProfileName.Text + "' Already Exists! Please Choose Another Profile Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!Directory.Exists(profilesDirectory))
                        {
                            Directory.CreateDirectory(profilesDirectory);
                        }
                        /* Profile Data Saving */
                        Save_Information_Profile info = new Save_Information_Profile();
                        info.ProfileName = txtProfileName.Text;
                        info.ProfileAvatar = cmbAvatar.Text;
                        info.Difficulty = cmbDifficulty.Text;
                        info.TotalScore = 0;
                        info.TotalWins = 0;
                        Save_Data.SaveData(info, profilesDirectory, txtProfileName.Text + ".xml");

                        /* Settings Data Saving */
                        Save_Information_Settings settings = new Save_Information_Settings();
                        settings.SelectedProfile = txtProfileName.Text;
                        Save_Data.SaveData(settings, SettingsDirectory, SettingsFileName);

                        /* Reload Home Form Values */
                        _Home_Main.reloadProfile();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The Following Errors Was Encountered - " + errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = false;
            }
        }
    }
}