using System;
using static System.Console;
using RPG_DIO.src.Classes;

namespace RPG_DIO.src
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Create 1st character");
            Character playerOne = Factory.CreateCharacter();
            WriteLine(playerOne.ToString());

            WriteLine("Create 2nd Character");
            Character playerTwo = Factory.CreateCharacter();
            WriteLine(playerTwo.ToString());
            
            WriteLine(playerOne.Attack(playerTwo));
            WriteLine(playerTwo.Attack(playerOne));
        }
    }
}