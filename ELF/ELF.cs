using System;


namespace ELF
{
   public abstract class ELF
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract string Subtype { get; set; }
        public abstract string Profession { get; set; }
        public abstract int Health { get; set; }
        public abstract int Energy { get; set; }
        public abstract Magic Magic { get; set;}
        public abstract Weapon Weapon { get; set; }
   
        public abstract void ShowHero();
        public abstract void AtackUseWeapon(ELF enemy);
        public abstract void AtackUseMagic(ELF enemy);
        public abstract void Speak();

    }
}
