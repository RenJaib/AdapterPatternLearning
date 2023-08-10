namespace StrategyExample.AttackStrategies
{
    public class FlyAttack:IPokemonAttackStrategy
    {
        public void Attack(string attackerName)
        {
            Console.WriteLine($"{attackerName} vanished by flying to sky!");
        }
    }
}