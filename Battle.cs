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
    public class Battle
    {
        static void Main(string[] args)
        {
            Battle battle;
            
            battle = new Battle();

            battle.doBattle();
        }

        public void doBattle()
        {
            int count = 10;
            List<IFighter> enemy;
            List<IFighter> army;

            //Ask the user if they wish to play again
            Console.WriteLine("Do you wish to play the battle game? Y/N \n");

            ConsoleKeyInfo ans = Console.ReadKey();

            if (ans.KeyChar == 'Y')
            {
                create(count, out enemy, out army);

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

                int enemyWins = 0;
                int friendlyWins = 0;

                fight(enemy, army, out enemyWins, out friendlyWins);

                // Print out how many times either the EnemyFighter or the FriendlyFighter won each battle
                Console.WriteLine("The enemy fighter battle victory score is:", enemyWins ,"\n");
                Console.WriteLine(enemyWins);
                Console.WriteLine("The friendly fighter battle victory score is:", friendlyWins ,"\n");
                Console.WriteLine(friendlyWins);

                // Print out whether the EnemyArmy or the FriendlyArmy won the game
                if (enemyWins > friendlyWins)
                {
                    Console.WriteLine("The enemy army has won the battle!");
                }
                else if (enemyWins < friendlyWins)
                {
                    Console.WriteLine("The friendly army has won the battle!");
                }
                else
                {
                    Console.WriteLine("The battle game is a draw!");
                }
            }

            Console.ReadLine();
        }

        public int fight(List<IFighter> enemy, List<IFighter> army, out int enemyWins, out int friendlyWins)
        {
            int soldier = 0;

            enemyWins = 0;
            friendlyWins = 0;

            // Increment and complete each fighter battle
            foreach (IFighter enemyFighter in enemy)
            {
                if (soldier < army.Count)
                {
                    bool enemyWin;

                    do
                    {
                        IFighter friendlyFighter = army[soldier];

                        // Count how many times either the FriendlyFighter or EnemyFighter wins the individual battle
                        enemyWin = getCombatResult(enemyFighter, friendlyFighter);

                        if (enemyWin == true)
                        {
                            enemyWins++;
                            soldier++;
                            enemyFighter.win();
                            friendlyFighter.loose();
                            Console.WriteLine("The winner of the battle is the enemy fighter " + enemyFighter.ToString() + "\n");
                        }
                        else
                        {
                            friendlyWins++;
                            enemyFighter.loose();
                            friendlyFighter.win();
                            Console.WriteLine("The winner of the battle is the friendly fighter " + friendlyFighter.ToString() + "\n");
                        }
                    }
                    while ((soldier < army.Count) && enemyWin);
                }
            }

            return enemyWins - friendlyWins;
        }

        public void create(int fighters, out List<IFighter> enemy, out List<IFighter> army)
        {
            //create Enemy Army
            EnemyArmy enemyArmy = new EnemyArmy();

            List<Enemy> enemies = enemyArmy.create(fighters);
            enemy = new List<IFighter>(fighters);
            foreach (IFighter enemyFighter in enemies)
            {
                enemy.Add(enemyFighter);
            }

            //create Friendly Army
            FriendlyArmy friendlyArmy = new FriendlyArmy();
            army = friendlyArmy.create(enemy.Count);
        }

        //Calculate the result/
        public bool getCombatResult(IFighter enemyfighter, IFighter friendlyfighter)
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
        public bool randomResult(Random r)
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
