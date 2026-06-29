
namespace Potyczka.Weapons;

public interface IWeapon
{
    string Name { get; }
    int Damage { get; }

    public int PerformAttack();
}