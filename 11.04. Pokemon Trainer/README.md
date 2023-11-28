# 4.Pokemon Trainer

Define a class **Trainer** and a class **Pokemon**.

**Trainers** have:

- **Name**
- **Number of badges**
- **Acollection of pokemon**

**Pokemon** have:

- **Name**
- **Element**
- **Health**

All values are **mandatory**. Every Trainer **starts with 0 badges**.

You will be receiving lines until you receive the command " **Tournament**". Each line will carry information about a pokemon and the trainer who caught it in the format:

**"\{trainerName} \{pokemonName} \{pokemonElement} \{pokemonHealth}"**

**TrainerName** is the name of the Trainer who caught the pokemon. Trainers' names are **unique**.
After receiving the command " **Tournament**", you will start receiving commands until the " **End**" command is received. They can contain one of the following:

- **"Fire"**
- **"Water"**
- **"Electricity"**

For every command, you must check if a trainer has at least 1 pokemon with the given element. If he does, he receives 1 badge. Otherwise, all of his pokemon **lose 10 health**. If a pokemon falls **to 0 or less health** , **he dies** and must be deleted from the trainer's collection. In the end, you should print all of the trainers, **sorted by the number of badges they have in descending order** (if two trainers have the same amount of badges, they should be sorted by order of appearance in the input)in the format:

**"\{trainerName} \{badges} \{numberOfPokemon}"**

## Examples

| **Input** | **Output** |
| --- | --- |
| Peter Charizard Fire 100<br>George Squirtle Water 38<br>Peter Pikachu Electricity 10<br>Tournament<br>Fire<br>Electricity<br>End | Peter 2 2<br>George 0 1 |
| Sam Blastoise Water 18<br>Narry Pikachu Electricity 22<br>John Kadabra Psychic 90<br>Tournament<br>Fire<br>Electricity<br>Fire<br>End | Narry 1 1<br>Sam 0 0<br>John 0 1 |