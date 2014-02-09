using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_Runner
{
    public class Save_Information_Profile
    {
        /* Profile/Player Settings */
        private string profileName;
        private string profileAvatar;
        private string difficulty;
        private int totalScore; 
        private int totalWins;

        /* Application Settings */
        private string selectedProfile;

        public string ProfileName
        {
            get { return profileName; }
            set { profileName = value; }
        }

        public string ProfileAvatar
        {
            get { return profileAvatar; }
            set { profileAvatar = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public int TotalWins
        {
            get { return totalWins; }
            set { totalWins = value; }
        }

        public string SelectedProfile
        {
            get { return selectedProfile; }
            set { selectedProfile = value; }
        }
    }
}