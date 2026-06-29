using System;
using System.Runtime.InteropServices;
using Potyczka.Battle;
using Potyczka.Roles.Models;
using Potyczka.Weapons;
using Potyczka.Roles;
using Potyczka.Roles.ModelsCreators;

namespace Potyczka;


class Program 
{

    static void Main() 
    {
        Character Person1 = CharacterSelection();
        WeaponSelection(Person1);

        Character Person2 = CharacterSelection();
        WeaponSelection(Person2);

        Game GameControler = new Game();
        GameControler.RunGame(Person1, Person2);
    }

    private static Character CharacterSelection()
    {
  
        CharacterSpawner characterSpawner = null;

        bool chosen = false;

        while(!chosen)
        {
            Console.WriteLine("Wybierz postac:");
            Console.WriteLine("1 - Warrior, 2 - Mage, 3 - Archer");
            string? SelectedNumber = Console.ReadLine();

            switch (SelectedNumber)
            {
                case "1":
                    characterSpawner = new WarriorCreator();
                    chosen = true;
                    break;
                case "2":
                    characterSpawner = new MageCreator();
                    chosen = true;
                    break;
                case "3":
                    characterSpawner = new ArcherCreator();
                    chosen = true;
                    break;
                default:
                    Console.WriteLine("Ta opcja nie istnieje. Wybierz poprawnie od 1 do 3");
                    break;
            }

        }

        Character SelectedCharacter = characterSpawner.CreateCharacter();
        return SelectedCharacter;
    }

    private static void WeaponSelection (Character Hero)
    {
        bool IsWeaponChoosen = false;

        while(!IsWeaponChoosen)
        {
            
            Console.WriteLine("Wybierz broń dla tej postaci:");
            for(int i = 0; i < Hero.AllowedWeapons.Count; ++i)
            {
                Console.WriteLine($"{i+1} - {Hero.AllowedWeapons[i].Name}");
            }

            string? SelectedAnswer = Console.ReadLine();

            if (int.TryParse(SelectedAnswer, out int wynik))
            {
                if(wynik <= 0 || wynik > Hero.AllowedWeapons.Count || !Hero.CanUseWeapon(Hero.AllowedWeapons[wynik-1])) 
                {
                    Console.WriteLine("Podano zła wartosc. Powtorz.");
                    continue;
                }

                IsWeaponChoosen = true;
                Hero.UseWeapon(Hero.AllowedWeapons[wynik-1]);
            }
            else
            {
                Console.WriteLine("Podano zła wartosc. Powtorz.");
                continue;
            }
        }
        
    }
}
