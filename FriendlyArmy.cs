//AndrewG8460
//Program file that creates the FriendlyArmy and adds fighters in the army using the FriendlyFighter class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
    public class FriendlyArmy
    {
        //Create the friendly army
        public List<IFighter> create(int count)
        {
            List<IFighter> fighters = new List<IFighter>(count);

            //Add fighters to the friendly army and get random parameters
            for (int i = 0; i < count; i++)
            {
                IFighter fighter;
                Random r = new Random();
                int fighterswitch = r.Next(4);
                switch (fighterswitch)
                {
                    case 1:
                        fighter = new FriendlyFighter(Weapon.SWORD, Magic.NONE);
                        break;
                    case 2:
                        fighter = new FriendlyFighter(Weapon.NONE, Magic.INVISIBILITY);
                        break;
                    case 3:
                        fighter = new FriendlyFighter(Weapon.FIRE, Magic.NONE);
                        break;
                    default:
                        fighter = new FriendlyFighter(Weapon.NONE, Magic.NONE);
                        break;
                }

                fighters.Add(fighter);

                
            }
            
            return fighters;
        }

        
    }
}
