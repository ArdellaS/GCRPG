using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int magicalEngery, int spellNumber)
            : base (name, strength, intelligence,magicalEngery)
        {
            SpellNumber = spellNumber;
        }

        public override string Play()
        {
            return $"{Name} (intelligence: {Intelligence}, strength: {Strength}, magic:  {MagicalEnergy}) {SpellNumber} spells";
        }
    }
}
