using System;
using static System.Console;
using RPG_DIO.src.Classes;

namespace RPG_DIO.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 10, 100, 20, "sword");
            Wizard Selemene = new Wizard("Selemene", 10, 50, 50, "fire");
            WriteLine(Arus.Attack(Selemene));
            WriteLine(Selemene.Attack(Arus));
        }
    }
}