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
            
            Console.WriteLine("Czy ta postać ma posiadać broń? (y/n) ");

            string? SelectedAnswer = Console.ReadLine();

            switch (SelectedAnswer)
            {
                case "y":
                    Hero.UseWeapon(new Sword());
                    Console.WriteLine($"{Hero.Name} otrzymał {Hero.Weapon.Name} o mocy {Hero.Weapon.Damage}");
                    IsWeaponChoosen = true;
                    break;
                case "n":
                    Hero.UseWeapon(new NoWeapon());
                    Console.WriteLine($"{Hero.Name} nie otrzyma żadnej broni");
                    IsWeaponChoosen = true;
                    break;
                default:
                    Console.WriteLine("Nie istnieje taka opcja, popraw swoja decyzje.");
                    break;
            }
        }
        
    }


    

}
