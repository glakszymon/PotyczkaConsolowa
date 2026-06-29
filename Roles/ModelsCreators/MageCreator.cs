
using Potyczka.Roles.Models;

namespace Potyczka.Roles.ModelsCreators;

public class MageCreator : CharacterSpawner
{
    public override Character CreateCharacter() => new Mage("Mage", Random.Shared);
}