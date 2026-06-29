using System;
using System.Runtime.InteropServices;
using Potyczka.Battle;
using Potyczka.Models;

namespace Potyczka;


class Program 
{

    static void Main() 
    {
        Character Person1 = CharacterSelection();
        Character Person2 = CharacterSelection();
        
        Game GameControler = new Game();
        GameControler.RunGame(Person1, Person2);
    }

    private static Character CharacterSelection()
    {
        Console.WriteLine("Wybierz postac:");
        Console.WriteLine("1 - Warrior, 2 - Mage, 3 - Archer");

        string SelectedNumber = Console.ReadLine();
        Character SelectedCharacter;

        switch (SelectedNumber)
        {
            case "1":
                SelectedCharacter = new Warrior("Warrior");
                break;
            case "2":
                SelectedCharacter = new Mage("Mage");
                break;
            case "3":
                SelectedCharacter = new Archer("Archer");
                break;
            default:
                Console.WriteLine("Ta opcja nie istnieje. Wybierz poprawnie od 1 do 3");
                SelectedCharacter = CharacterSelection();
                break;
        }

        return SelectedCharacter;
    }


    

}
