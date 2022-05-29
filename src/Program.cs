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
            
            ReadLine();
            Random rnd = new Random();
            while(true)
            {
                if (rnd.Next(1,3) == 1)
                    if(!playerOne.Attack(playerTwo))
                        break;
                else
                    if(!playerTwo.Attack(playerOne))
                        break;
            }
            ReadLine();
        }
    }
}