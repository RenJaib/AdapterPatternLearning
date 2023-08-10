using StrategyExample.AttackStrategies;

namespace StrategyExample.Pokemons;

public class Charmander : IPokemon
{

    string _name;
    IPokemonAttackStrategy _attackStrategy;

    public Charmander(string name, IPokemonAttackStrategy attackStrategy)
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