using System;
using System.Collections.Generic;
using System.Text;

namespace vmerkleFinal
{
    public class BaseCharacterStats
    {
        //Set private decimals that are the players attributes
        private decimal healthPoints;
        private decimal maxHealthPoints;
        private decimal attackDamage;
        private decimal defenseAmount;
        private decimal baseDefense;

        string name = string.Empty;

        public string Name
        {
            get { return Name; }
        }

        //Constructor takes predetermined values given when creating player objects and sets the decimals above equal to those values.
        public BaseCharacterStats(decimal hPIn, decimal attackIn, decimal defenseIn)
        {
            maxHealthPoints = hPIn;
            healthPoints = hPIn;
            attackDamage = attackIn;
            baseDefense = defenseIn;
            defenseAmount = defenseIn;
        }

        //Make private decimals available to the rest of the code.
        public decimal DefenseAmount
        {
            get { return defenseAmount; }
            set { defenseAmount = value; }
        }

        public decimal HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }

        public decimal MaxHealthPoints
        {
            get { return maxHealthPoints; }
            set { maxHealthPoints = value; }
        }

        public decimal AttackDamage
        {
            get { return attackDamage; }
            set { attackDamage = value; }
        }

        public decimal BaseDefense
        {
            get { return baseDefense; }
            set { baseDefense = value; }
        }

        //This method is used by players and monsters to determine the amount of damage that will be given to one another
        public decimal DealDamage(decimal baseDamage) 
        {
            attackDamage = baseDamage;
            return (attackDamage);
        }

        //This method is used by players and monsters to actually take the damage determined in deal damage
        public void TakeDamage(decimal damageIn) 
        {
            healthPoints = healthPoints - (damageIn * DefenseAmount);
        }
    }
}
