using System;


namespace ELF
{
    public class ElvinElder : ElvinOracle
    {
        public ElvinElder(string name)
        {
            Profession = "Elvin Elder";
            Name = name;
            Energy = 15;
            Weapon.SetDamage(2);
        }
    }
}
