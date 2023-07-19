using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcs_vs_Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Johnny");
            Orc orc1 = new Orc("Bilbo");

            int Round = 0;

            while (human1.getCurrentHealth() > 0 && orc1.getCurrentHealth() > 0)
            {
                Round = 1 + Round;
                Console.WriteLine("Round " + Round);
                Console.WriteLine();

                int humanDamage = human1.Attack();

                orc1.setHealth(humanDamage);

                human1.displayStats();
                orc1.displayStats();

                Console.WriteLine("Human attacks and deals " + humanDamage + " damage to orc.");

                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("Round " + Round);

                int orcDamage = orc1.Attack();

                human1.setHealth(orcDamage);

                human1.displayStats();
                orc1.displayStats();

                Console.WriteLine("Orc attacks and deals " + orcDamage + " damage to human.");

                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
