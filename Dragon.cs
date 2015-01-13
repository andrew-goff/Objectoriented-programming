//AndrewG8460
//Program file that creates the dragon class and inherits from FriendlyFighter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
    public class Dragon : FriendlyFighter
    {
        public Dragon (int id) : base(id, Weapon.FIRE, Magic.NONE)
        {   
        }
        //Print out the description of the dragon fighter in the string
        public override string ToString()
        {
            return "Dragon " + base.ToString();
        }
    }
}
