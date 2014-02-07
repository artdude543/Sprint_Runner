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
        string PlayerProfileName = "";

        public Profile_Edit()
        {
            InitializeComponent();
        }

        private void Profile_Edit_Load(object sender, EventArgs e)
        {
            if (File.Exists(ProfilesDirectory + "artdude543.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream(ProfilesDirectory + "artdude543.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);

                /* Load Player Information */
                txtPlayerName.Text = info.PlayerName;
            }
        }
    }
}
