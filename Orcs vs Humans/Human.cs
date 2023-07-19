using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcs_vs_Humans
{
    class Human : Creature
    {
        protected int medicine;

        public Human(string x)
        {
            name = x;
            species = "Human";
            baseAttack = rn.Next(7, 11);
            baseHealth = rn.Next(40, 51);
            medicine = rn.Next(3, 9);
            currentHealth = baseHealth;
        }

        public override int Attack()
        {
            int RandomNumber = rn.Next(0, 2);
            if (RandomNumber == 0 && medicine > 0)
            {
                currentHealth = currentHealth + rn.Next(5, 11);
                medicine = medicine - 1;
            }

            return baseAttack + rn.Next(0, 6);
        }

        public override void displayStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Species: " + species);
            Console.WriteLine("Base Attack: " + baseAttack);
            Console.WriteLine("Current Health: " + currentHealth);
            Console.WriteLine("Medicine: " + medicine);
            Console.WriteLine();
        }
    }
}
