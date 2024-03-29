using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vmerkleFinal
{
    public partial class GameWindow : Form
    {
        //When the window is opened, all neccesary objects are created for reference later.
        Bandit banditMonster = new Bandit(250, 30, 0.6m);
        Ogre ogreMonster = new Ogre(225, 50, 0.5m);
        Dragon dragonMonster = new Dragon(275, 50, 0.4m);

        Cleric clericPlayer = new Cleric(150, 45, 0.7m);
        Mage magePlayer = new Mage(175, 50, 0.7m);
        Fighter fighterPlayer = new Fighter(200, 65, 0.6m);

        GameData currentGameData = new GameData();
        int deaths = 0;

        public GameWindow() //This is just the primary method that creates the form and sets things up
        {
            InitializeComponent();
            FillActionBox();
        }

        //This method fills the player's action boxes, the monster picture, hp labels, etc
        void FillActionBox()
        {
            enemyPB.Image = imageList1.Images[0];
            turnResultTB.Text = "Oh no! A bandit has appeared";
            monsterHealthLabel.Text = "HP: " + banditMonster.HealthPoints + "/" + banditMonster.MaxHealthPoints;

            if (currentGameData.PlayerOne == "Cleric")
            {
                clericHealthLabel.Text = "HP: " + clericPlayer.HealthPoints + "/" + clericPlayer.MaxHealthPoints;
                clericActionCB.Items.Add("Hit");
                clericActionCB.Items.Add("Heal");
                clericActionCB.Items.Add("Block");
            }
            if (currentGameData.PlayerTwo == "Mage")
            {
                mageHealthLabel.Text = "HP: " + magePlayer.HealthPoints + "/" + magePlayer.MaxHealthPoints;
                mageActionCB.Items.Add("Hit");
                mageActionCB.Items.Add("Magic Spell");
                mageActionCB.Items.Add("Block");
            }
            if (currentGameData.PlayerThree == "Fighter")
            {
                fighterHealthLabel.Text = "HP: " + fighterPlayer.HealthPoints + "/" + fighterPlayer.MaxHealthPoints;
                fighterActionCB.Items.Add("Hit");
                fighterActionCB.Items.Add("Sword");
                fighterActionCB.Items.Add("Block");
                
            }
        }

        //This method checks all the players health to see if they are dead after the turn or not
        public int CheckPlayerHP(GameData currentGameData)
        {
            int num = 0;
            if (currentGameData.PlayerOne == "Cleric")
            {
                if (clericPlayer.HealthPoints <= 0)
                {
                    currentGameData.PlayerOne = "";
                    clericActionCB.Items.Clear();
                    num++;
                }
            }
            if (currentGameData.PlayerTwo == "Mage")
            {
                if (magePlayer.HealthPoints <= 0)
                {
                    currentGameData.PlayerTwo = "";
                    mageActionCB.Items.Clear();
                    num++;
                }
            }
            if (currentGameData.PlayerThree == "Fighter")
            {
                if (fighterPlayer.HealthPoints <= 0)
                {
                    currentGameData.PlayerThree = "";
                    fighterActionCB.Items.Clear();
                    num++;
                }
            }
            return num;
        }

        //This method checks the monster's health to see if they are dead after the turn or not and if so gets the next monster set up
        public void CheckMonsterHP(GameData currentGameData)
        {
            switch (currentGameData.CurrentMonster)
            {
                case "Bandit":
                    {
                        if (banditMonster.HealthPoints <= 0)
                        {
                            enemyPB.Image = imageList1.Images[5]; ;
                            currentGameData.CurrentMonster = "Ogre";
                            turnResultTB.Text += Environment.NewLine + "You killed the Bandit! \nOh no! A Ogre has appeared!";
                            monsterHealthLabel.Text = "HP: " + ogreMonster.HealthPoints + "/" + ogreMonster.MaxHealthPoints;
                            magePlayer.Mana += 1000;
                            clericPlayer.Mana += 1000;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(banditMonster.HealthPoints) + "/" + banditMonster.MaxHealthPoints;
                            break;
                        }
                    }
                case "Ogre":
                    {
                        if (ogreMonster.HealthPoints <= 0)
                        {
                            enemyPB.Image = imageList1.Images[2]; ;
                            currentGameData.CurrentMonster = "Dragon";
                            turnResultTB.Text += Environment.NewLine + "You killed the Ogre! \nThe dragon has been waiting for you!";
                            monsterHealthLabel.Text = "Monster HP: " + dragonMonster.HealthPoints + "/" + dragonMonster.MaxHealthPoints;
                            magePlayer.Mana += 1000;
                            clericPlayer.Mana += 1000;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(ogreMonster.HealthPoints) + "/" + ogreMonster.MaxHealthPoints;
                            break;
                        }
                    }
                case "Dragon":
                    {
                        if (dragonMonster.HealthPoints <= 0)
                        {
                            turnResultTB.Text += Environment.NewLine + "You killed the dragon and beat the game!";
                            System.Windows.Forms.MessageBox.Show("You killed the dragon and beat the game!");
                            this.Close();
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(dragonMonster.HealthPoints) + "/" + dragonMonster.MaxHealthPoints;
                            break;
                        }
                    }
            }
        }

        //This method just puts the hp of the players and monsters on the form and updates them as health is taken or added
        public void ShowDamageTaken(decimal damageIn, int characterAttacked)
        {
            switch (characterAttacked) //Takes the damage the monster is dealing and deals it to the a random player
            {
                case 1:
                    {
                        decimal damageTaken = damageIn * clericPlayer.DefenseAmount;
                        turnResultTB.Text += Environment.NewLine + "Cleric took " + Math.Round(damageTaken) + " damage.";
                        clericHealthLabel.Text = "HP: " + Math.Round(clericPlayer.HealthPoints) + "/" + clericPlayer.MaxHealthPoints;
                        break;
                    }
                case 2:
                    {
                        decimal damageTaken = damageIn * magePlayer.DefenseAmount;
                        turnResultTB.Text += Environment.NewLine + "Mage took " + Math.Round(damageTaken) + " damage.";
                        mageHealthLabel.Text = "HP: " + Math.Round(magePlayer.HealthPoints) + "/" + magePlayer.MaxHealthPoints;
                        break;
                    }
                case 3:
                    {
                        decimal damageTaken = damageIn * fighterPlayer.DefenseAmount;
                        turnResultTB.Text += Environment.NewLine + "Fighter took " + Math.Round(damageTaken) + " damage.";
                        fighterHealthLabel.Text = "HP: " + Math.Round(fighterPlayer.HealthPoints) + "/" + fighterPlayer.MaxHealthPoints;
                        break;
                    }
                case 4: //hits all players if it's the dragon's fire attack
                    {
                        decimal damageTaken1 = damageIn * clericPlayer.DefenseAmount;
                        turnResultTB.Text += Environment.NewLine + "Cleric took " + Math.Round(damageTaken1) + " damage.";
                        clericHealthLabel.Text = "HP: " + Math.Round(clericPlayer.HealthPoints) + "/" + clericPlayer.MaxHealthPoints;
                        decimal damageTaken2 = damageIn * magePlayer.DefenseAmount;
                        turnResultTB.Text += Environment.NewLine + "Mage took " + Math.Round(damageTaken2) + " damage.";
                        mageHealthLabel.Text = "HP: " + Math.Round(magePlayer.HealthPoints) + "/" + magePlayer.MaxHealthPoints;
                        decimal damageTaken3 = damageIn * fighterPlayer.DefenseAmount;
                        turnResultTB.Text += Environment.NewLine + "Fighter took " + Math.Round(damageTaken3) + " damage.";
                        fighterHealthLabel.Text = "HP: " + Math.Round(fighterPlayer.HealthPoints) + "/" + fighterPlayer.MaxHealthPoints;
                        break;
                    }
            }
        }

        private void startTurnButton_Click(object sender, EventArgs e)
        {
            //Ranodm character for enemy to attack
            Random rnd = new Random();
            int characterAttacked = rnd.Next(1, 4);

            //Set starting damage amounts to be used later
            decimal totalMonsterDamage = 0;
            decimal tempPlayerDamage = 0;
            decimal totalPlayerDamage = 0;

            switch (currentGameData.CurrentMonster) //Randomly chooses one of the attacks from the monsters choices of attacks
            {
                case "Bandit":
                    {
                        tempPlayerDamage += banditMonster.DoAction(currentGameData, this);
                        totalPlayerDamage += tempPlayerDamage;
                        break;
                    }
                case "Ogre":
                    {
                        tempPlayerDamage += ogreMonster.DoAction(currentGameData, this);
                        totalPlayerDamage += tempPlayerDamage;
                        break;
                    }
                case "Dragon":
                    {
                        int dragonAttack = rnd.Next(1, 3);
                        switch (dragonAttack)
                        {
                            case 1:
                                {
                                    tempPlayerDamage = dragonMonster.Fire();
                                    turnResultTB.Text += Environment.NewLine + "The Dragon burned you with its fire!";
                                    characterAttacked = 4;
                                    break;
                                }
                            case 2:
                                {
                                    tempPlayerDamage = dragonMonster.Swipe();
                                    turnResultTB.Text += Environment.NewLine + "The Dragon swipped at you!";
                                    break;
                                }
                        }
                        totalPlayerDamage += tempPlayerDamage;
                        break;
                    }
            }

            if (currentGameData.PlayerOne == "Cleric") //Takes the action chosen for the 1st character and deals damage
            {

                totalMonsterDamage += clericPlayer.DoAction(clericActionCB.Text, currentGameData, clericPlayer, magePlayer, fighterPlayer, this);

            }

            if (currentGameData.PlayerTwo == "Mage") //Takes the action chosen for the 2nd character and deals damage
            {

                totalMonsterDamage += magePlayer.DoAction(mageActionCB.Text, this);

            }

            if (currentGameData.PlayerThree == "Fighter") //Takes the action chosen for the 3rd character and deals damage
            {

                totalMonsterDamage += fighterPlayer.DoAction(fighterActionCB.Text);

            }

            switch (currentGameData.CurrentMonster) //Takes the damage the players are dealing and deals it to the monster
            {
                case "Bandit":
                    {
                        banditMonster.TakeDamage(totalMonsterDamage);
                        break;
                    }
                case "Ogre":
                    {
                        ogreMonster.TakeDamage(totalMonsterDamage);
                        break;
                    }
                case "Dragon":
                    {
                        dragonMonster.TakeDamage(totalMonsterDamage);
                        break;
                    }
            }

            switch (characterAttacked) //Takes the damage the monster is dealing and deals it to the a random player or all players if it's dragon fire
            {
                case 1:
                    {
                        clericPlayer.TakeDamage(totalPlayerDamage);
                        break;
                    }
                case 2:
                    {
                        magePlayer.TakeDamage(totalPlayerDamage);
                        break;
                    }
                case 3:
                    {
                        fighterPlayer.TakeDamage(totalPlayerDamage);
                        break;
                    }
                case 4:
                    {
                        clericPlayer.TakeDamage(totalPlayerDamage);
                        magePlayer.TakeDamage(totalPlayerDamage);
                        fighterPlayer.TakeDamage(totalPlayerDamage);
                        break;
                    }
            }



            //Updates players health label
            ShowDamageTaken(totalPlayerDamage, characterAttacked);

            //Checks to see if player or monster died
            CheckMonsterHP(currentGameData);
            deaths += CheckPlayerHP(currentGameData);

            //Checks if all characters have died and if so then ends game
            if (deaths == 3)
            {
                System.Windows.Forms.MessageBox.Show("Game Over!");
                this.Close();
            }

            //Resets player defense
            fighterPlayer.DefenseAmount = fighterPlayer.BaseDefense;
            magePlayer.DefenseAmount = magePlayer.BaseDefense;
            clericPlayer.DefenseAmount = clericPlayer.BaseDefense;

        }
    }
}
