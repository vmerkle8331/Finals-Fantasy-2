using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    public class Mage : BaseCharacterStats
    {
        //Constructor takes neccesary variables and creates mage player.
        public Mage(decimal hPIn, decimal attackIn, decimal defenseIn) : base(hPIn, attackIn, defenseIn) 
        {

        }

        private decimal mana = 1000; // Mage uses special variable mana to restrict spell use. Player starts with 1000 mana points.
        string name = "Mage";

        public decimal Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public string Name
        {
            get { return name; }
        }

        //Deals minimum amount of damage
        public decimal Hit()
        {
            return (DealDamage(AttackDamage));
        }

        //Blocks all damage taken from enemy
        public decimal Block()
        {
            return DefenseAmount = 0m;
        }

        //Deals max amount of damage and costs 200 mana to use, if 200 mana is not available the attack fails
        public decimal MagicSpell(GameWindow gameWindow)
        {
            if (mana - 200 >= 0)
            {
                //if the player has enough mana, the player's mana is reduced and a higher attack stat is returned.
                mana -= 200;
                return AttackDamage * 2;
            }
            else
            {
                // If the mage doesn't have enough mana, text is displayed to notify the player.
                gameWindow.turnResultTB.Text += Environment.NewLine + "You don't have enough mana to use a spell! Regain mana by killing monsters!";
                return (0);
            }
        }

        // DoAction takes all needed data to determine and execute the user's selected action.
        public decimal DoAction(string actionName, GameWindow gameWindow)
        {
            //variable damageTotal is created to store the total amount of damage the mage will do this turn. 
            decimal damageTotal = 0;

            switch (actionName)
            {
                //Selects which action should be executed depending on the user's input via the drop down menu. 
                case "Hit":
                    {
                        damageTotal = Hit();
                        return damageTotal;
                    }
                case "Magic Spell":
                    {
                        damageTotal = MagicSpell(gameWindow);
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
