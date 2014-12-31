//AndrewG8460
//Program file that get the CombatResult of both fighters and declares the winning fighter and the winning army
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyFighters;

namespace ConsoleDrivenBattleGame
{
    class Battle
    {

        static void Main(string[] args)
        {
            Battle battle;
            
            battle = new Battle();

            battle.doBattle();
        }

        public void doBattle()
        {
            List<Enemy> enemy;
            List<IFighter> army;

            create(10, out enemy, out army);

            // TODO: learn enumerators
            // List<IFighter>.Enumerator friendlyFighters = army.GetEnumerator();
            // Initialise the variables
            int enemyWins = 0;
            int friendlyWins = 0;
            int i = 0;
        
            //Ask the user if they wish to play again
            Console.WriteLine("Do you wish to play the battle game? Y/N \n");

            ConsoleKeyInfo ans = Console.ReadKey();

            if (ans.KeyChar == 'Y')
            {
                //Ask the user if they want to inspect the enemy Army
                Console.WriteLine("Do you want to inspect the enemy army? \n");
                ConsoleKeyInfo inspect = Console.ReadKey();

                if (inspect.KeyChar == 'y')
                {
                       
                    foreach ( IFighter enemyFighter in enemy)
                    {
  
                        //String the instances on one line containing the enemy fighter
                        //Inspect the enemy army and ask the user to rearrange enemy fighters
                        Console.WriteLine("Enemy fighter:" + enemyFighter.ToString() + "\n");                    
                    }
                    Console.WriteLine("Do you want to rearrange the enemy army? \n");

                    ConsoleKeyInfo rearrange = Console.ReadKey();
                    if (rearrange.KeyChar == 'y')
                    {
                        //Rearrange the enemy fighters
                        Console.WriteLine("Do you wish to keep the order as it is or rearrange it?");
                        ConsoleKeyInfo reverse = Console.ReadKey();

                        if (reverse.KeyChar == 'y')
                        {
                            enemy.Reverse();
                        }
                    }
                }

                // Increment and complete each fighter battle
                foreach ( IFighter enemyFighter in enemy)
                {
                    IFighter friendlyFighter = army[i++];

                    // Count how many times either the FriendlyFighter or EnemyFighter wins the individual battle
                    bool enemyWin = getCombatResult(enemyFighter, friendlyFighter);
                
                    if (enemyWin == true)
                    {
                        enemyWins++;
                        Console.WriteLine("The winner of the battle is the enemy fighter " + enemyFighter.ToString() + "\n");
                    }
                    else
                    {
                        friendlyWins++;
                        Console.WriteLine("The winner of the battle is the friendly fighter " + friendlyFighter.ToString() + "\n");
                    }
                }

                // Print out how many times either the EnemyFighter or the FriendlyFighter won each battle
                Console.WriteLine("The enemy fighter battle victory score is:", enemyWins ,"\n");
                Console.WriteLine(enemyWins);
                Console.WriteLine("The friendly fighter battle victory score is:", friendlyWins ,"\n");
                Console.WriteLine(friendlyWins);

                // Print out whether the EnemyArmy or the FriendlyArmy won the game
                if (friendlyWins < enemyWins)
                {
                    Console.WriteLine("The enemy army has won the battle!");
                }
                else if (friendlyWins > enemyWins)
                {
                    Console.WriteLine("The friendly army has won the battle!");
                }
                else if (friendlyWins == enemyWins)
                {
                     Console.WriteLine("The battle game is a draw!");
                }
            }

            //Print out stastitics showing the best and worst fighters for the enemy and friendly army
            foreach (IFighter enemyFighter in enemy)
            {
                if (enemyWins > friendlyWins)
                { 
                    Console.WriteLine("The most successful enemy fighter is:" + enemyFighter.getId() + "\n");
                }
                else if (friendlyWins > enemyWins)
                {
                    Console.WriteLine("The least successful enemy fighter is:" + enemyFighter.getId() + "\n");
                }
            }
            
            Console.ReadLine();
        }

        private static void create(int fighters, out List<Enemy> enemy, out List<IFighter> army)
        {
            //create Enemy Army
            EnemyArmy enemyArmy = new EnemyArmy();

            enemy = enemyArmy.create(fighters);

            //create Friendly Army
            FriendlyArmy friendlyArmy = new FriendlyArmy();
            army = friendlyArmy.create(enemy.Count);
        }

        //Calculate the result/
        private static bool getCombatResult(IFighter enemyfighter, IFighter friendlyfighter)
        {
            Random r = new Random();

            //Determine if the enemyFigher has either weapon or magic
            if (enemyfighter.getMagic() == friendlyfighter.getMagic())
            {
                if (enemyfighter.getWeapon() == friendlyfighter.getWeapon())
                {
                    return randomResult(r);
                }
                else if (enemyfighter.getWeapon() == Weapon.SWORD)
                {
                    return true; // Enemy fighter wins
                }
                else
                {
                    return false; // Friendly fighter wins
                }
            }
            else if (enemyfighter.getMagic() == Magic.INVISIBILITY)
            {
                return true; // Enemy fighter wins
            }
            else
            {
                return false; // Friendly fighter wins
            }
        }
        // Get the random Result of the friendly army
        private static bool randomResult(Random r)
        {
            // Random result
            if (r.Next() > 0.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
