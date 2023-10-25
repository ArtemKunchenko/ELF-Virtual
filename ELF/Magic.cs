using System;


namespace ELF
{
    internal class Magic
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }

        public Magic(string name, int damage, int level)
        {
            Name = name;
            Damage = damage;
            Level = level;
        }
    }
}
