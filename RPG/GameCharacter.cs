using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;


        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public string Name { get => name; set => name = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }

        public virtual string Play()
        {
            return $"{Name} (intelligence: {Intelligence}, strength: {Strength}";
        }
    }
}
