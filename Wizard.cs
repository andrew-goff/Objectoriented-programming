//AndrewG8460
//Program file that creates the Wizard fighter class and inherits from FriendlyFighter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
    public class Wizard : FriendlyFighter
    {
	    public Wizard (int id): base(id, Weapon.SWORD, Magic.INVISIBILITY)
        {
	    }

        //Print out the wizard fighter in the string
        public override string ToString()
        {
            return "Wizard " + base.ToString();
        }
    }
}