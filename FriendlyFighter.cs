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
            int id = 0;
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

        Weapon weapon;
        Magic magic;
        getId id; 


        public FriendlyFighter(Weapon pweapon, Magic pmagic)
        {
            // Initialization of the constructor
            this.weapon = pweapon;
            this.magic = pmagic;
        }


     }
}
