using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class MagicUsingCharacter:GameCharacter
    {
        private int magicalEngery;
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEngery)
            :base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEngery;
        }
        public override string Play()
        {
            return
            $"{Name} (intelligence: {Intelligence}, strength: {Strength}, magic:  {MagicalEnergy}) "; 
                
        }
    }
}
