using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmerkleFinal
{
    public class GameData
    {
        string playerOne = "Cleric";
        string playerTwo = "Mage";
        string playerThree = "Fighter";
        string currentMonster = "Bandit";

        //Make private variables available to the rest of the code
        public string PlayerOne
        {
            get { return playerOne; }
            set { playerOne = value; }
        }

        public string PlayerTwo
        {
            get { return playerTwo; }
            set { playerTwo = value; }
        }

        public string PlayerThree
        {
            get { return playerThree; }
            set { playerThree = value; }
        }

        public string CurrentMonster
        {
            get { return currentMonster; }
            set { currentMonster = value; }
        }
    }
}
