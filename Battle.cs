//AndrewG8460
//Program file that gets the CombatResult of both fighters, declares the winning fighter and the winning army and prints out statistics
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
            //Create a class called Battle and a method DoBattle
            Battle battle;

                battle = new Battle((int)DateTime.Now.Ticks & 0x0000FFFF);

            battle.doBattle();
        }

        protected Random r;
        //Initialise the random number seed
        public Battle(int seed)
        {
            r = new Random(seed);
        }

        public void doBattle()
        {
            int count = 10;
            List<IFighter> enemy;
            List<IFighter> army;

            //Ask the user if they wish to play again
            if (getInput("Do you wish to play the battle game"))
            {
                    create(count, out enemy, out army);

                    Console.WriteLine("\n");

                    //Ask the user if they want to inspect the enemy Army
                    if (getInput("Do you want to inspect the enemy army"))
                    {

                        foreach (IFighter enemyFighter in enemy)
                        {
                            //String the instances on one line containing the enemy fighter
                            //Inspect the enemy army and ask the user to rearrange enemy fighters
                            Console.WriteLine("Enemy fighter:" + enemyFighter.ToString() + "\n");
                        }

                        //Ask the user if they want to rearrange the enemy arm
                        if (getInput("Do you want to rearrange the enemy army"))
                        {
                            //Rearrange the enemy fighters
                            Console.WriteLine("\n");

                            if (getInput("Do you wish to keep the order as it is or rearrange it"))
                            {
                                enemy.Reverse();
                            }
                        }
                    }
                    

                int enemyWins = 0;
                int friendlyWins = 0;

                fight(enemy, army, out enemyWins, out friendlyWins);

                IFighter bestEnemy;
                IFighter worstEnemy;
                IFighter bestFriendly;
                IFighter worstFriendly;
                
                //Print out the statistics showing the worst and best enemy and friendly fighters
                statistics(enemy, out bestEnemy, out worstEnemy);

                Console.WriteLine("The best enemy fighter is:" + bestEnemy + "\n");

                Console.WriteLine("The worst enemy fighter is:" + worstEnemy + "\n");


                statistics(army, out bestFriendly, out worstFriendly);
                Console.WriteLine("The best friendly fighter is:" + bestFriendly + "\n");

                Console.WriteLine("The worst friendly fighter is:" + worstFriendly + "\n");


                // Print out how many times either the EnemyFighter or the FriendlyFighter won each battle
                Console.WriteLine("The enemy fighter battle victory score is:" + enemyWins + "\n");

                Console.WriteLine("The friendly fighter battle victory score is:" + friendlyWins + "\n");


                // Print out whether the EnemyArmy or the FriendlyArmy won the game or the game was a draw
                if (enemyWins > friendlyWins)
                {
                    Console.WriteLine("The enemy army has won the battle!" + "\n");
                }
                else if (enemyWins < friendlyWins)
                {
                    Console.WriteLine("The friendly army has won the battle!" + "\n");
                }
                else
                {
                    Console.WriteLine("The battle game is a draw!" + "\n");
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
                            Console.WriteLine("Enemy fighter " + enemyFighter + " beats friendly fighter " + friendlyFighter + "\n");
                        }
                        else
                        {
                            friendlyWins++;
                            enemyFighter.loose();
                            friendlyFighter.win();
                            Console.WriteLine("Friendly fighter " + friendlyFighter + " beats enemy fighter " + enemyFighter + "\n");
                        }
                    }
                    while ((soldier < army.Count) && enemyWin);
               }
            }

            return enemyWins - friendlyWins;
        }

        //Print out stastistics showing the best and worst fighters for the enemy and friendly army
        public void statistics(List<IFighter> army, out IFighter best, out IFighter worst)
        {
            best = army[0];
            worst = army[0];

            //Get the best and worst fighters in each army
            foreach (IFighter soldier in army)
            {
                if (best.getWins() < soldier.getWins())
                {
                    best = soldier;
                }

                if (worst.getWins() > soldier.getWins())
                {
                    worst = soldier;
                }
            }
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
            if (r.Next(2) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Test if the input is invalid and print prompt
        public bool getInput(string prompt) 
        {
            string error = "invalid input, please try again";

            while (true)
           {
               Console.WriteLine(prompt + " [y/n] ?");

               ConsoleKeyInfo choice = Console.ReadKey();

               if (choice.KeyChar == 'y')
               {
                   return true; //Input by user is correct
               }
               else if (choice.KeyChar == 'n')
               {
                   return false; //Input by user is incorrect
               }
               else
               {
                   Console.WriteLine(error + " ["+choice.KeyChar+"]\n");
               }
           }
        }
    }
}
