
using Potyczka.Roles.Models;
using Potyczka.Roles;

namespace Potyczka.Roles.ModelsCreators;

public class WarriorCreator : CharacterSpawner
{
    public override Character CreateCharacter()
    {
        return new Warrior("Warrior", Random.Shared);
    } 
}