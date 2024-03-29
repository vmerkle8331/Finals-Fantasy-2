using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    public class Cleric : BaseCharacterStats
    {
        //Constructor takes neccesary variables and creates cleric player.
        public Cleric(decimal hPIn, decimal attackIn, decimal defenseIn) : base(hPIn, attackIn, defenseIn) 
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

        //Heal spell heals 50 Health points to every character and costs 200 mana. If 200 mana is not available the spell fails.
        public void Heal(GameData currentData, Cleric clericPlayer, Mage magePlayer, Fighter fighterPlayer, GameWindow gameWindow) 
        {
            if (mana - 200 >= 0)
            {
                //if the player has enough mana, the player's mana is reduced and the proper character are healed. 
                mana -= 200;

                clericPlayer.HealthPoints += 50;
                magePlayer.HealthPoints += 50;
                fighterPlayer.HealthPoints += 50;

            }
            else
            {
                // If the mage doesn't have enough mana, text is displayed to notify the player.
                gameWindow.turnResultTB.Text += Environment.NewLine + "You don't have enough mana to heal! Regain mana by killing monsters!";
            }
        }

        // DoAction takes all needed data to determine and execute the user's selected action.
        public decimal DoAction(string actionName, GameData currentData, Cleric clericPlayer, Mage magePlayer, Fighter fighterPlayer, GameWindow gameWindow)
        {
            //variable damageTotal is created to store the total amount of damage the cleric will do this turn. 
            decimal damageTotal = 0;

            switch (actionName)
            {
                //Selects which action should be executed depending on the user's input via the drop down menu. 
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
                case "Heal":
                    { 
                        Heal(currentData, clericPlayer, magePlayer, fighterPlayer, gameWindow);
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
