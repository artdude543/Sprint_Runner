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
    public partial class Race_Main : MetroForm
    {
        private readonly Home_Main _Home_Main;

        public Race_Main(Home_Main HomeMain)
        {
            InitializeComponent();

            this._Home_Main = HomeMain;
        }

        private void Race_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}