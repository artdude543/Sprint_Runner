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
                Information info = new Information();
                info.PlayerName = txtPlayerName.Text;

                Save_Profile_Data.SaveData(info, ProfilesDirectory + txtPlayerName.Text + ".xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}