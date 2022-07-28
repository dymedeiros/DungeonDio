using System;
using DungeonDio.src.Entities;

namespace DungeonDio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus",1,"Knight");
            Wizard wizard = new Wizard("Jenica", 1, "White Wizard");


            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
