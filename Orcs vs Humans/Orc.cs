using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcs_vs_Humans
{
    class Orc : Creature
    {
        public Orc(string x)
        {
            name = x;
            species = "Orc";
            baseAttack = rn.Next(10, 16);
            baseHealth = rn.Next(45, 71);
            currentHealth = baseHealth;
        }

        public override int Attack()
        {
            if (currentHealth < .5 * baseHealth)
            {
                return baseAttack + 2 * rn.Next(0, 6);
            }
            else
            {
                return baseAttack + rn.Next(0, 6);
            }
            
        }
    }
}
