
using Potyczka.Roles.Models;

namespace Potyczka.Roles.ModelsCreators;

public class ArcherCreator : CharacterSpawner
{
    public override Character CreateCharacter() => new Archer("Archer", Random.Shared);
}