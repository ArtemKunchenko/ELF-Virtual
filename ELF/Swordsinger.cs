using System;


namespace ELF
{
    public class Swordsinger : ElvinKnight
    {
        public Swordsinger(string name)
        {
            Profession = "Swordsinger";
            Name = name;
            Energy = 20;
            Weapon.SetDamage(2);
        }
    }
}
