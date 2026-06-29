using System;
using System.Runtime.CompilerServices;
using Potyczka.Models;

namespace Potyczka.Battle;

public class Game
{
    private Character Atacker;
    private Character Defender;
    
    public void RunGame(Character Person1, Character Person2)
    {
        int RoundsCounter = 0;

        Atacker = Person1;
        Defender = Person2;

        while(true)
        {
            ++RoundsCounter;
            Console.WriteLine($"----- Round {RoundsCounter} -----");


            int AtackPower = Atacker.Atack();
            Defender.ReciveDamage(AtackPower);
            if(!Defender.CheckIsALive())
            {
                break;
            }

            Console.WriteLine("");
            Atacker.ShowStats();
            Defender.ShowStats();
            Console.WriteLine("----------------------------------");

            ChangeSides();
        }

        EndGame(Atacker, Defender);
        return;
    }

    private void ChangeSides()
    {
        Character temp = Atacker;
        Atacker = Defender;
        Defender = temp;
    }

    private void EndGame(Character Winner, Character Loser)
    {
        Console.WriteLine("KONIEC GRY");
        Console.WriteLine($"{Winner.Name} wygrywa.");
        Console.WriteLine("Wyniki postaci: ");
        Winner.ShowStats();
        Loser.ShowStats();
        return;
    }
}