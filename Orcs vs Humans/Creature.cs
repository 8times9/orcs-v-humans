using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcs_vs_Humans
{
    class Creature
    {
        protected string name;
        protected string species;
        protected int baseHealth;
        protected int baseAttack;
        protected int currentHealth;

        public int getCurrentHealth()
        {
            return currentHealth;
        }

        public static Random rn = new Random();

        public Creature() { }

        public virtual int Attack()
        {
            return baseAttack + rn.Next(0, 6);
        }

        public void setHealth(int x)
        {
            currentHealth = currentHealth - x;
        }

        public virtual void displayStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Species: " + species);
            Console.WriteLine("Base Attack: " + baseAttack);
            Console.WriteLine("Current Health: " + currentHealth);
            Console.WriteLine();
        }
    }

}
