namespace StrategyExample.AttackStrategies;

public class ThunderboltAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used Thunderbolt!");
    }
}