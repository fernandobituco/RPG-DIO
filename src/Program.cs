using System;
using static System.Console;
using RPG_DIO.src.Classes;

namespace RPG_DIO.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Character playerOne = Factory.CreateCharacter();
            Character playerTwo = Factory.CreateCharacter();
            WriteLine(playerOne.Attack(playerTwo));
            WriteLine(playerTwo.Attack(playerOne));
        }
    }
}