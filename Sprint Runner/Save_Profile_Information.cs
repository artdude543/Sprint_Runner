﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_Runner
{
    public class Save_Profile_Information
    {

        private string profileName;
        private string difficulty;
        private int totalScore; 
        private int totalWins;

        public string ProfileName
        {
            get { return profileName; }
            set { profileName = value; }
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
    }
}