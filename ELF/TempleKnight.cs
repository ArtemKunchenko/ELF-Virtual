using System;


namespace ELF
{
    public class TempleKnight:ElvinKnight
    {
        public TempleKnight(string name) 
        {
            Profession = "Temple Knight";
            Name = name;
            Energy = 15;
            Weapon.SetDamage(1);
        }
    }
}
