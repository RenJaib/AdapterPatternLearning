using StrategyExample.AttackStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Pokemons
{
    public class PokemonFactory
    {
        public static IPokemon CreatePokemon(string name, string type)
        {
            switch (type)
            {
                case "Charmander":
                    var a = new SomeSuperClass(name);
                    return new Charmander(name, a);
                case "Squirtle":
                    return new Squirtle(name, new WaterblastAttack());
                case "Pikachu":
                    return new Pikachu(name, new ThunderboltAttack());
                case "Bulbasaur":
                    return new Bulbasaur(name, new MachineGunAttack());
                case "Charizard":
                    return new Charizard(name, new FlyAttack());
                default:
                    throw new ArgumentException("Invalid type");
            }
        }

    }

    
}
