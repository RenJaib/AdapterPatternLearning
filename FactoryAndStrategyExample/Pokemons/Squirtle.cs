using StrategyExample.AttackStrategies;
using System.Xml.Linq;

namespace StrategyExample.Pokemons;

public class Squirtle : IPokemon
{
    private string _name;
    private IPokemonAttackStrategy _pokemonAttackStrategy;
    public Squirtle(string name, WaterblastAttack waterblastAttack)
    {
        _name = name;
        _pokemonAttackStrategy = waterblastAttack;

    }

    public void Attack()
    {
        _pokemonAttackStrategy.Attack(_name);
    }

    public void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy)
    {
        newAttackStrategy.Attack(_name);

    }
}