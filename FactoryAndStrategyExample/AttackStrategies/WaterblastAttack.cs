using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.AttackStrategies
{
    public class WaterblastAttack: IPokemonAttackStrategy
    {
        public void Attack(string attackerName)
        {
            Console.WriteLine($"{attackerName} used Waterblast!");
        }
    }
}
