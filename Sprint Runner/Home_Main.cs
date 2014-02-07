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
    public partial class Home_Main : MetroForm
    {
        public Home_Main()
        {
            InitializeComponent();
            // Load Application Settings
            loadSettings();
        }
        public void loadSettings()
        {

        }
        private void cmdTemp_Click(object sender, EventArgs e)
        {
            new Profile_Create().ShowDialog();
        }
        private void cmdProfileEdit_Click(object sender, EventArgs e)
        {
            new Profile_Edit().ShowDialog();
        }

        private void cmdProfileSelect_Click(object sender, EventArgs e)
        {
            new Profile_Select().ShowDialog();
        }
    }
}