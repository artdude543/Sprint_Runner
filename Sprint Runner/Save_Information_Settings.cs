using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_Runner
{
    public class Save_Information_Settings
    {
        /* Application Settings */
        private string selectedProfile;

        public string SelectedProfile
        {
            get { return selectedProfile; }
            set { selectedProfile = value; }
        }
    }
}