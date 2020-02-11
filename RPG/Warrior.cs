using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Warrior: GameCharacter
    {
        private string weaponType;

        public Warrior(string name, int strength, int intelligence, string weaponType)
            :base  (name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }

        public string WeaponType { get => weaponType; set => weaponType = value; }

        public override string Play()
        {
            return
                base.Play() + $" {WeaponType}";
        }

    }
}
