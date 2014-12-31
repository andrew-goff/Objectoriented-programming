//AndrewG8460
//Program file that creates the Swordsman class and inherits from FriendlyFighter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
    public class Swordsman : FriendlyFighter
    {
        public Swordsman(int id): base(id, Weapon.SWORD, Magic.NONE)
        {

        }

        public override string ToString()
        {
            return "Swordsman " + base.ToString();
        }
    }
}
