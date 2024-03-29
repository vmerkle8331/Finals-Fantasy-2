using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    public class Dragon : BaseCharacterStats
    {
        //Constructor takes neccesary variables and creates dragon enemy
        public Dragon (decimal hPIn, decimal attackIn, decimal defenseIn) : base(hPIn, attackIn, defenseIn) 
        {

        }

        public decimal Fire() //basic attack that gives minimal damage but hits all players
        {
            return DealDamage(AttackDamage);
        }

        public decimal Swipe() //second attack that does more damage to a single player
        {
            return DealDamage(AttackDamage * 2);

        }
    }
}
