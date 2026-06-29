
namespace Potyczka.Weapons;

public class Staff : IWeapon
{
    public string Name => "Staff";
    public int Damage => 20; 

    public int PerformAttack()
    {
        return Damage;
    }
}
