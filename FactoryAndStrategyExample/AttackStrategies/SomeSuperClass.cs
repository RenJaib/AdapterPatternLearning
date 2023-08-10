namespace StrategyExample.AttackStrategies
{
    public class SomeSuperClass : IPokemonAttackStrategy
    {
        private string name;

        public SomeSuperClass(string name)
        {
            this.name = $"Super {name}";
        }

        public void Attack(string attackerName)
        {
            Console.WriteLine($"{attackerName} used Waterblast with help of {name}!");
        }
    }
}