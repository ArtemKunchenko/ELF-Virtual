using System;


namespace ELF
{
    public class ElvinKnight:ElvinFighter
    {
        public ElvinKnight() 
        {
            Subtype = "Elvin Knight";
            Magic.SetName("Air");
            Magic.SetDamage(1);
            Weapon = new Weapon("Sword", 0);
        }    
    }
}
