﻿using System;

namespace ELF
{
    internal class Weapon
    {
        public string Name { get; set; }    
        public int Damage { get; set; }

        public Weapon(string name, int damage) 
        {
            Name = name;
            Damage = damage;
        }
    }
}