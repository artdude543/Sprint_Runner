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
    public partial class Profile_Select : MetroForm
    {
        string ProfilesDirectory = "profiles/";

        public Profile_Select()
        {
            InitializeComponent();
            loadProfiles();
        }

        private void loadProfiles()
        {
            DirectoryInfo dir = new DirectoryInfo(ProfilesDirectory);
            FileInfo[] fileList = dir.GetFiles("*.xml", SearchOption.AllDirectories);

            foreach(FileInfo file in fileList)
            {
                comboBox1.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }
    }
}
