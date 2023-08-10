using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyExample.AttackStrategies;

namespace StrategyExample.Pokemons
{
    public class Pikachu:IPokemon
    {
        string _name;
        IPokemonAttackStrategy _attackStrategy;

        public Pikachu(string name, IPokemonAttackStrategy attackStrategy)
        {
            _name = name;
            _attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            _attackStrategy.Attack(_name);
        }

        public void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy)
        {
            newAttackStrategy.Attack(_name);
        }
    }
}
