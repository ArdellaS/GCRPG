using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Wizard("Evil Stepmother",3,6,6,2));
            gameCharacters.Add(new Warrior("Prince Adam the barbarian", 10, 5, "Sword of Power"));
            gameCharacters.Add(new Wizard("Morrigan the swamp witch", 2, 9, 10, 5));
            gameCharacters.Add(new Warrior("King \"Bowser\" Koopa", 6,1,"Claws"));
            gameCharacters.Add(new Wizard("Yuna the summoner", 1, 7, 9, 3));

            foreach (GameCharacter person in gameCharacters)
            {
                Console.WriteLine($"{person.Play()}\n");
            }

            
        }
    }
}
