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
        Random r = new Random();

        //Create the friendly army
        public List<IFighter> create(int count)
        {
            List<IFighter> fighters = new List<IFighter>(count);

            //Add fighters to the friendly army and get random parameters
            for (int i = 0; i < count; i++)
            {
                IFighter fighter;

                int fighterswitch = r.Next(4);

                switch (fighterswitch)
                {
                    case 1:
                        fighter = new Swordsman(i+1);
                        break;
                    case 2:
                        fighter = new Wizard(i+1);
                        break;
                    case 3:
                        fighter = new Dragon(i+1);
                        break;
                    default:
                        fighter = new FriendlyFighter(i+1, Weapon.NONE, Magic.NONE);
                        break;
                }

                fighters.Add(fighter);

                
            }
            
            return fighters;
        }

        
    }
}
