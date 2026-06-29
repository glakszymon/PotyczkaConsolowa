
namespace Potyczka.Weapons;

public class Sword : IWeapon
{
    public string Name => "Sword";
    public int Damage => 30; 

    public int PerformAttack()
    {
        return Damage;
    }
}
