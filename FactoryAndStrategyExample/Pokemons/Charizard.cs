using StrategyExample.AttackStrategies;
using System.Xml.Linq;

namespace StrategyExample.Pokemons
{
    public class Charizard : IPokemon
    {
        private string _name;
        private IPokemonAttackStrategy _attackStrategy;
        public Charizard( string name, IPokemonAttackStrategy attackStrategy)
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