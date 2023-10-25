using System;


namespace ELF
{
    public class ElvinOracle : ElvinMystic
    {
        public ElvinOracle()
        {
            Subtype = "Elvin Oracle";
            Magic.SetName("Water");
            Magic.SetDamage(4);
            Weapon = new Weapon("Scepter", 0);
        }
    }
}
