using StrategyExample.AttackStrategies;

namespace StrategyExample;

public interface IPokemon
{
    void Attack();
    void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy);
}