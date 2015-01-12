//AndrewG8460
//Program getting the interface IFighter for use with the FriendlyFighter class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
     public class FriendlyFighter : IFighter
     //Initialise the Interface/
     {  
         //Get method properties from getId, getMagic and getWeapon
        public int getId()
        {
            return id;
        }
        public Weapon getWeapon()
        {
            return weapon;
        }

        public Magic getMagic()
        {
            return magic;
        }

        int id;
        Weapon weapon;
        Magic magic;
        private int wins = 0;
        private int loss = 0;

        public FriendlyFighter(int id, Weapon pweapon, Magic pmagic)
        {
            // Initialization of the constructor
            this.id = id;
            this.weapon = pweapon;
            this.magic = pmagic;
        }

        //Set method properties for win, getWins, loose and hasLost
        public void win()
        {
            wins++;
        }

        public int getWins()
        {
            return wins;
        }

        public void loose()
        {
            loss++;
        }

        public bool hasLost()
        {
            return loss > 0;
        }
        //Print out the friendly fighter description in the string
        public override string ToString()
        {
            return id + ", " + magic + ", " + weapon;
        }
     }
}
