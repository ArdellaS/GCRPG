using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class MagicUsingCharacter:GameCharacter
    {
        private int magicalEnergy;

        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEngery)
            :base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEngery;
        }
        public override string Play()
        {
            return
            $"{Name} (intelligence: {Intelligence}, strength: {Strength}, magic:  {magicalEnergy}) "; 
                
        }
    }
}
