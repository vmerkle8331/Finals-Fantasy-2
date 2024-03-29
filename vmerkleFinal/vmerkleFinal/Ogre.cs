using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    class Ogre : BaseCharacterStats
    {
        //Constructor takes neccesary variables and creates ogre enemy.
        public Ogre(decimal hPIn, decimal attackIn, decimal defenseIn) : base(hPIn, attackIn, defenseIn)  
        {

        }

        public decimal ThrowRock() //basic attack that gives minimal damage
        {
            return DealDamage(AttackDamage);
        }

        public decimal Mace() //second attack that does more damage
        {
            return DealDamage(AttackDamage * 2);

        }
        public decimal DoAction(GameData currentData, GameWindow gameWindow)
        {
            //random number is given to choose which attack is used
            Random rnd = new Random();
            int num = rnd.Next(1, 3);

            decimal damageTotal = 0;

            switch (num)
            {
                case 1:
                    {
                        damageTotal = ThrowRock();
                        gameWindow.turnResultTB.Text += Environment.NewLine + "The Ogre threw a rock at you!";
                        break;
                    }
                case 2:
                    {
                        damageTotal = Mace();
                        gameWindow.turnResultTB.Text += Environment.NewLine + "The Ogre attacked with it's mace!";
                        break;
                    }
            }

            return damageTotal;
        }
    }
}
