using System;


namespace ELF
{
    public class ElementalSummer : ElvinWizard
    {
        public ElementalSummer(string name)
        {
            Profession = "Elemental Summer";
            Name = name;
            Energy = 15;
            Weapon.SetDamage(1);
        }
    }
}
