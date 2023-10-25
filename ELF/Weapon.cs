﻿using System;

namespace ELF
{
    public class Weapon
    {
        public string Name { get; set; }    
        public int Damage { get; set; }

        public Weapon(string name, int damage) 
        {
            Name = name;
            Damage = damage;
        }
        public void SetName(string name) { Name = name; }
        public void SetDamage(int damage) { Damage = damage; }
    }
}
