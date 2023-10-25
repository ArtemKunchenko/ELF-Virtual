using System;


namespace ELF
{
    public class ElvinWizard : ElvinMystic
    {
        public ElvinWizard()
        {
            Subtype = "Elvin Wizard";
            Magic.SetName("Fire");
            Magic.SetDamage(3);
            Weapon = new Weapon("Knife", 0);
        }
    }
}
