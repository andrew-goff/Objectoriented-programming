//AndrewG8460
//Program file that creates the Wizard fighter class inheriting from the FriendlyFighter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
    public class Wizard : FriendlyFighter
    {
        //Create the wizard fighter
        private int wizard;

	    public Wizard (int Wizard, int getId, Weapon pweapon, Magic pmagic): base(pweapon, pmagic)
        {
            wizard = Wizard;
	    }

        public int getWizard()
        {           
            return wizard;
        }
    }
}