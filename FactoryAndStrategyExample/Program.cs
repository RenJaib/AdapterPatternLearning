// See https://aka.ms/new-console-template for more information

using StrategyExample;
using StrategyExample.AttackStrategies;
using StrategyExample.Pokemons;

Console.WriteLine("Hello, World!");


var pikachu = PokemonFactory.CreatePokemon("Max", "Pikachu");

pikachu.Attack();

var charmander = PokemonFactory.CreatePokemon("FireZ", "Charmander");
charmander.Attack();

//maybe User choose a different type of attack
pikachu.SetNewStrategy(new FireboltAttack());

pikachu.Attack();

pikachu.SetNewStrategy(new WaterblastAttack());

pikachu.Attack();
pikachu.SetNewStrategy(new WaterblastAttack());
pikachu.Attack();
 
Console.WriteLine("Below is homework");
var bulbasaur = PokemonFactory.CreatePokemon("Bulbul", "Bulbasaur");
bulbasaur.Attack();

bulbasaur.SetNewStrategy(new FlyAttack());
bulbasaur.SetNewStrategy(new MachineGunAttack());

var charizard = PokemonFactory.CreatePokemon("Charzu", "Charizard");
charizard.Attack();
charizard.SetNewStrategy(new SomeSuperClass("Bulbul"));