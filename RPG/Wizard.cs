using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int magicalEngery, int spellNumber)
            : base (name, strength, intelligence,magicalEngery)
        {
            this.spellNumber = spellNumber;
        }

        public override string Play()
        {
            return 
                base.Play() + $"  magic:  {MagicalEnergy}) {SpellNumber} spells";
        }
    }
}
