using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    class Bandit : BaseCharacterStats
    {
        public Bandit(decimal hPIn, decimal attackIn, decimal defenseIn) //Constructor takes neccesary variables and creates bandit enemy. 
            : base(hPIn, attackIn, defenseIn)
        {

        }

        public decimal ThrowKnife() //basic attack that gives minimal damage
        {
            return DealDamage(AttackDamage);
        }

        public decimal Sword() //second attack that does more damage
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
                        damageTotal = ThrowKnife();
                        gameWindow.turnResultTB.Text += Environment.NewLine + "The Bandit threw a knife at you!";
                        break;
                    }
                case 2:
                    {
                        damageTotal = Sword();
                        gameWindow.turnResultTB.Text += Environment.NewLine + "The Bandit attacked with it's sword!";
                        break;
                    }
            }

            return damageTotal;
        }
    }
}
