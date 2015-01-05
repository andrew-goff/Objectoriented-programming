/* 
 * drjhunter 
 * This is this the set of classes, enums and interface that make up 
 * EnemyFighters.dll, the library issued to students for the OOP assignment 2014. 
 * This code is not to be issued as source, only binary. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyFighters
{

    public enum Magic
    {
        NONE,
        INVISIBILITY
    }

    public enum Weapon
    {
        NONE,
        FIRE,
        SWORD
    }

    public interface IFighter
    {
        Weapon getWeapon();
        Magic getMagic();
        int getId();

        void win();
        void loose();

        int getWins();
        bool hasLost();
    }

    public class Enemy : IFighter
    {
        private Weapon weapon;
        private Magic magic;
        private int id;
        private int wins = 0;
        private int loss = 0;

        public Enemy(int fighterNumber)
        {
            // randomly select magic and weapon choices 
            // seed using a system-generated number 
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int i = random.Next(3);
            weapon = (Weapon)i;
            i = random.Next(2);
            magic = (Magic)i;
            id = fighterNumber;
        }

        public Weapon getWeapon()
        {
            return weapon;
        }

        public Magic getMagic()
        {
            return magic;
        }

        public int getId()
        {
            return id;
        }

        public void win()
        {
            wins++;
        }

        public int getWins()
        {
            return wins;
        }

        public void loose()
        {
            loss++;
        }

        public bool hasLost()
        {
            return loss > 0;
        }

        public override string ToString()
        {
            return id + ", " + magic + ", " + weapon;
        }
    }

    // factory method, responsible solely for creating 
    // a List of enemy fighters 
    public class EnemyArmy
    {
        private int size;

        public EnemyArmy()
        {
            size = 0;
        }

        private void incrementSize()
        {
            size = size + 1;
        }

        // returns a List containing the specified number 
        // of Enemy objects 
        public List<Enemy> create(int len)
        {
            Enemy e;
            List<Enemy> lEnemy = new List<Enemy>();

            for (int i = 0; i < len; i++)
            {
                incrementSize();
                e = new Enemy(size);
                lEnemy.Add(e);
            }

            return lEnemy;


    
        }
    }
}