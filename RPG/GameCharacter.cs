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

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual string Play()
        {
            return $"{Name} (intelligence: {Intelligence}, strength: {Strength}";
        }
    }
}
