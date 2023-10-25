using System;
using static System.Net.Mime.MediaTypeNames;


namespace ELF
{
    public class ElvinFighter : ELF
    {
        public override string Name { get ; set ; }
        public override string Type { get; set; }
        public override string Subtype { get; set; }
        public override string Profession { get; set; }
        public override int Health { get; set; }
        public override int Energy { get; set; }
        public override Magic Magic { get; set; }
        public override Weapon Weapon { get; set; }
        public ElvinFighter()  
        { 
           
            Type = "Elvin Fighter";
            Health = 20;
            Magic = new Magic("", 0, 0);
            Magic.SetLevel(10);
        } 
        public override void AtackUseMagic(ELF enemy)
        {
            Console.WriteLine($"{Name} is using magic ");
            enemy.Health -= Magic.Damage;
            Magic.Level -= Magic.Damage;
        }

        public override void AtackUseWeapon(ELF enemy)
        {
            Console.WriteLine($"{Name} is using weapon ");
            enemy.Health -= Weapon.Damage;
            Energy -= Weapon.Damage;
        }

        public override void ShowHero()
        {
            Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"Type: {Type} ");
            Console.WriteLine($"Subtype: {Subtype} ");
            Console.WriteLine($"Profession: {Profession} ");
            Console.WriteLine($"Magic type: {Magic.Name} ");
            Console.WriteLine($"Weapon type: {Weapon.Name} ");
            Console.Write($"Health ({Health}):\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < Health; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Write($"Energy ({Energy}):\t\t");
            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < Energy; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Write($"Magic lavel ({Magic.Level}):\t");
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Magic.Level; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();


        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} is speaking ");
        }
    }
}
