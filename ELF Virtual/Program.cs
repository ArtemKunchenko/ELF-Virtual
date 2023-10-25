using System;
using ELF;

namespace ELF_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ElvinElder player = new ElvinElder("Alex");
            player.ShowHero();
           
            Console.ReadKey();
        }
    }
}
