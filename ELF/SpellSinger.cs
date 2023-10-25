using System;


namespace ELF
{
    public class SpellSinger : ElvinWizard
    {
        public SpellSinger(string name)
        {
            Profession = "SpellSinger";
            Name = name;
            Energy = 20;
            Weapon.SetDamage(2);
        }
    }
}
