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
            else if (cmbDifficulty.Text == "")
            {
                error = true;
                errorMessage = "Difficulty Not Set!";
            }
            else if (cmbAvatar.Text == "")
            {
                error = true;
                errorMessage = "Avatar Not Set!";
            }
            if (!error)
            {
                try
                {
                    if (File.Exists(profilesDirectory + txtProfileName.Text + ".xml"))
                    {
                        MessageBox.Show("Profile Save Already Exists! Please Choose Another Profile Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Save_Profile_Information info = new Save_Profile_Information();

                        info.ProfileName = txtProfileName.Text;
                        info.ProfileAvatar = cmbAvatar.Text;
                        info.Difficulty = cmbDifficulty.Text;
                        info.TotalScore = 0;
                        info.TotalWins = 0;

                        Save_Profile_Data.SaveData(info, profilesDirectory, txtProfileName.Text + ".xml");

                        /* Set Current Profile As The New Profile Created */
                        Properties.Settings.Default.ProfileName = txtProfileName.Text;
                        Properties.Settings.Default.ProfileSet = true;
                        Properties.Settings.Default.Save();

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
                MessageBox.Show("Please Correct Your Errors Before Continuing. Error: " + errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = false;
            }
        }
    }
}