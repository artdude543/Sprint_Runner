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
        string ProfilesDirectory = "profiles/";
        string ProfileName = Properties.Settings.Default.ProfileName + ".xml";

        public Profile_Edit()
        {
            InitializeComponent();
        }

        private void Profile_Edit_Load(object sender, EventArgs e)
        {
            if (File.Exists(ProfilesDirectory + ProfileName))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Save_Profile_Information));
                FileStream read = new FileStream(ProfilesDirectory + ProfileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Save_Profile_Information info = (Save_Profile_Information)xs.Deserialize(read);

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