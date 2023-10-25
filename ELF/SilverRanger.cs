using System;


namespace ELF
{
    public class SilverRanger : ElvinScout
    {
        public SilverRanger(string name)
        {
            Profession = "Silver Ranger";
            Name = name;
            Energy = 20;
            Weapon.SetDamage(2);
        }
    }
}
