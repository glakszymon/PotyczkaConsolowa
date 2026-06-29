
namespace Potyczka.Weapons;

public class Bow : IWeapon
{
    public string Name => "Bow";
    public int Damage => 15;  


    public int PerformAttack()
    {
        return Damage;
    }
}