using System;
using System.Runtime.CompilerServices;
using Potyczka.Extra;
using Potyczka.Roles;

namespace Potyczka.Battle;

public class Game
{
    private Character Attacker;
    private Character Defender;
    
    public void RunGame(Character Person1, Character Person2)
    {
        int RoundsCounter = 0;

        Attacker = Person1;
        Defender = Person2;

        while(true)
        {
            ++RoundsCounter;
            Console.WriteLine($"-------------------- Round {RoundsCounter} --------------------");

            AttackerResponse AttackStats = Attacker.Attack();

            Console.WriteLine($"{Attacker.Name} uderza z mocą {AttackStats.PotentialPointsForAttack}. Trafił {(AttackStats.HitFactor < 0 ? "niedokładnie i zmniejsza" : "idealnie i zwieksza")} siłe ataku o {AttackStats.HitFactor}");

            DefenderResponse DefenderStats = Defender.ReciveDamage(AttackStats.FinalAttack);

            Console.WriteLine($"{Defender.Name} otrzymal {DefenderStats.PotentialDamageRecived} punktow obrazen. Obronił sie przed {DefenderStats.SavedDamage} punktami obrażeń. Stracił {DefenderStats.FinalDamageRecived} HP");
            Console.WriteLine("");

            ShowStats(Attacker);
            ShowStats(Defender);
            Console.WriteLine("=================================================");

            if(!DefenderStats.IsAlive) break;

            ChangeSides();
        }

        EndGame(Attacker, Defender);
        return;
    }

    private void ChangeSides()
    {
        Character temp = Attacker;
        Attacker = Defender;
        Defender = temp;
    }

    private void EndGame(Character Winner, Character Loser)
    {
        Console.WriteLine("KONIEC GRY");
        Console.WriteLine($"{Winner.Name} wygrywa.");
        Console.WriteLine("Wyniki postaci: ");
        ShowStats(Winner);
        ShowStats(Loser);
        return;
    }

    public void ShowStats(Character person)
    {
        Console.WriteLine($"[{person.Name}] HP: {person.Health} | STR: {person.Strength} | WEAPON: {(person.Weapon == null ? "Brak" : person.Weapon.Name)} ");
    }

}