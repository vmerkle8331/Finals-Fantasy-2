using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    public class Fighter : BaseCharacterStats
    {
        //Constructor takes neccesary variables and creates fighter player.
        public Fighter(decimal hPIn, decimal attackIn, decimal defenseIn) : base(hPIn, attackIn, defenseIn)
        {

        }

        string name = "Fighter";

        public string Name
        {
            get { return name; }
        }

        //Deals max amount of damage
        private decimal Sword()
        {
            return AttackDamage * 2;
        }

        //Deals minimum amount of damage
        private decimal Hit()
        {
            return DealDamage(AttackDamage);
        }

        //Blocks all damage taken from enemy
        public decimal Block()
        {
            return DefenseAmount = 0m;
        }

        // DoAction takes all needed data to determine and execute the user's selected action.
        public decimal DoAction(string actionName)
        {
            //variable damageTotal is created to store the total amount of damage the mage will do this turn. 
            decimal damageTotal = 0;
            switch (actionName)
            {
                //Selects which action should be executed depending on the user's input via the drop down menu. 
                case "Sword":
                    {
                        damageTotal = Sword();
                        return damageTotal;
                    }
                case "Hit":
                    {
                        damageTotal = Hit();
                        return damageTotal;
                    }
                case "Block":
                    {
                        Block();
                        return damageTotal;
                    }
                default:
                    {
                        return damageTotal;
                    }
            }
        }
    }
}
