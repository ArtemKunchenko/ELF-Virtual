using System;
using System.Diagnostics;
using ELF;

namespace ELF_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int type = 0;
            int subtype = 0;
            int profession = 0;
            string name = "";
            int choice = 0;
            ChoiceHero(ref type, ref subtype, ref profession, ref name);
            choice = type * 100 + subtype * 10 + profession;
            var player = CreateHero(choice, name);
            TempleKnight enemy = new TempleKnight("Bob");
            Console.WriteLine("\t\tYour Hero ");
            player.ShowHero();
            Console.WriteLine("\t\tYour enemy: ");
            enemy.ShowHero();
            Console.WriteLine("\t\tYour hero is atacking");
            player.AtackUseWeapon(enemy);
            Console.WriteLine("\t\tYour hero after atack");
            player.ShowHero();
            Console.WriteLine("\t\tYour enemy after atack");    
            enemy.ShowHero();
            Console.WriteLine("\t\tYour hero is atacking");
            player.AtackUseMagic(enemy);
            Console.WriteLine("\t\tYour hero after atack");
            player.ShowHero();
            Console.WriteLine("\t\tYour enemy after atack");
            enemy.ShowHero();


            Console.ReadKey();
        }
        #region CHOICE HERO
        static void ChoiceHero(ref int type, ref int subtype, ref int profession, ref string name)
        {
            Console.Write("Input name of hero: ");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("Choose the type:");
                Console.WriteLine("1 - Elvin Fighter");
                Console.WriteLine("2 - Elvin Mystic");
                type = int.Parse(Console.ReadLine());
                if (type == 1 || type == 2) break;
                Console.WriteLine("Error! Invalid value!");
            } while (type != 1 && type != 2);
            Console.Clear();
            if (type == 1)
            {
                do
                {
                    Console.WriteLine("Choose the subtype:");
                    Console.WriteLine("1 - Elvin Knight");
                    Console.WriteLine("2 - Elvin Scout");
                    subtype = int.Parse(Console.ReadLine());
                    if (subtype == 1 || subtype == 2) break;
                    Console.WriteLine("Error! Invalid value!");
                } while (subtype != 1 && subtype != 2);
                Console.Clear();
                if (subtype == 1)
                {
                    do
                    {
                        Console.WriteLine("Choose the profession:");
                        Console.WriteLine("1 - Temple Knight");
                        Console.WriteLine("2 - Swordsinger");
                        profession = int.Parse(Console.ReadLine());
                        if (profession == 1 || profession == 2) break;
                        Console.WriteLine("Error! Invalid value!");
                    } while (profession != 1 && profession != 2);
                    Console.Clear();
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Choose the profession:");
                        Console.WriteLine("1 - Plainwalker");
                        Console.WriteLine("2 - Silver Ranger");
                        profession = int.Parse(Console.ReadLine());
                        if (profession == 1 || profession == 2) break;
                        Console.WriteLine("Error! Invalid value!");
                    } while (profession != 1 && profession != 2);
                    Console.Clear();
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Choose the subtype:");
                    Console.WriteLine("1 - Elvin Wizard");
                    Console.WriteLine("2 - Elvin Oracle");
                    subtype = int.Parse(Console.ReadLine());
                    if (subtype == 1 || subtype == 2) break;
                    Console.WriteLine("Error! Invalid value!");
                } while (subtype != 1 && subtype != 2);
                Console.Clear();
                if (subtype == 1)
                {
                    do
                    {
                        Console.WriteLine("Choose the profession:");
                        Console.WriteLine("1 - Elemental Summer");
                        Console.WriteLine("2 - Spellsinger");
                        profession = int.Parse(Console.ReadLine());
                        if (profession == 1 || profession == 2) break;
                        Console.WriteLine("Error! Invalid value!");
                    } while (profession != 1 && profession != 2);
                    Console.Clear();
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Choose the profession:");
                        Console.WriteLine("1 - Elvin Elder");
                        profession = int.Parse(Console.ReadLine());
                        if (profession == 1) break;
                        Console.WriteLine("Error! Invalid value!");
                    } while (profession != 1);
                    Console.Clear();
                }
            }
        }
        #endregion

        #region CREATE HERO
        static dynamic CreateHero(int choice, string name)
        {
            switch (choice)
            {
                case 111:
                    return new TempleKnight(name);

                case 112:
                    return new Swordsinger(name);
                case 121:
                    return new Plainswalker(name);
                case 122:
                    return new SilverRanger(name);
                case 211:
                    return new ElementalSummer(name);
                case 212:
                    return new SpellSinger(name);
                case 221:
                    return new ElvinElder(name);
                default: return null;
            }

        } 
        #endregion
    }
}
