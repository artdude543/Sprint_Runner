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
        string ProfilesDirectory = "profiles/";

        public Profile_Create()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(ProfilesDirectory + txtProfileName.Text + ".xml"))
                {
                    MessageBox.Show("Profile Save Already Exists! Please Choose Another Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Save_Profile_Information info = new Save_Profile_Information();
                    info.ProfileName = txtProfileName.Text;
                    info.Difficulty = cmbDifficulty.Text;
                    info.TotalScore = 0;
                    info.TotalWins = 0;

                    Save_Profile_Data.SaveData(info, ProfilesDirectory, txtProfileName.Text + ".xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}