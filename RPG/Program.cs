using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> character = new List<GameCharacter>();
            character.Add(new Warrior("Brick the Tank", 7, 3, "Axe"));
            character.Add(new Wizard("Morrigan the swamp witch", 2, 9, 100, 5));
            character.Add(new Warrior("Prince Adam the barbarian", 10,5, "Sword of Power"));
            character.Add(new Warrior("King \"Bowser\" Koopa", 6,1,"Claws"));

            foreach (GameCharacter person in character)
            {
                Console.WriteLine($"{person.Play()}\n");
            }

            
        }
    }
}
