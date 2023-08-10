using StrategyExample.AttackStrategies;

namespace StrategyExample.Pokemons
{
    public class Bulbasaur : IPokemon
    {
        private string _name;
        private IPokemonAttackStrategy _attackStrategy;
        public Bulbasaur(string name, IPokemonAttackStrategy attackStrategy)
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