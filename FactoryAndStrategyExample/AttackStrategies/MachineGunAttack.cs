namespace StrategyExample.AttackStrategies
{
    public class MachineGunAttack : IPokemonAttackStrategy
    {
        public void Attack(string attackerName)
        {
            Console.WriteLine($"{attackerName} used machine gun!");
        }
    }
}