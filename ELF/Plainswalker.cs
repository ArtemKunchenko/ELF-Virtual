using System;


namespace ELF
{
    public class Plainswalker : ElvinScout
    {
        public Plainswalker(string name)
        {
            Profession = "Plainswalker";
            Name = name;
            Energy = 15;
            Weapon.SetDamage(1);
        }
    }
}
