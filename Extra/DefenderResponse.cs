
namespace Potyczka.Extra;

public class DefenderResponse
{
    public int FinalDamageRecived { get; private set;}
    public int PotentialDamageRecived { get; private set; }
    public int SavedDamage { get; private set; }
    public bool IsAlive {get; private set; }

    public DefenderResponse(int finalDamageRecived, int potentialDamageRecived, int savedDamage, bool isAlive)
    {
        FinalDamageRecived = finalDamageRecived;
        PotentialDamageRecived = potentialDamageRecived;
        SavedDamage = savedDamage;
        IsAlive = isAlive;
    }
}