using System;


namespace ELF
{
    public class ElvinScout : ElvinFighter
    {
        public ElvinScout()
        {
            Subtype = "Elvin Scout";
            Magic.SetName("Earth");
            Magic.SetDamage(2);
            Weapon = new Weapon("Bow", 0);
        }
    }
}
