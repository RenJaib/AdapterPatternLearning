namespace StrategyExample.AttackStrategies;

public class FireboltAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used Firebolt!");
    }
}