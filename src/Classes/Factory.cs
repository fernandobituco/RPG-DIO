using static System.Console;

namespace RPG_DIO.src.Classes
{
    static public class Factory
    {
        private static string? name;
        private static string? type;
        private static int hp;
        private static int mp;

        public static Character CreateCharacter()
        {
            WriteLine("Type your character's name");
            name = getName();
            
            while (true)
            {
                WriteLine("Type the class you wish to be (k for Knight or w for Wizard)");
                type = ReadLine();
                if(type == "w" || type == "k")
                    break;
                else
                    WriteLine("Invalid input");
            }

            if (type == "k")
            {
                KnightHpMp();
                Knight knight = new Knight(name, 1, hp, mp, new Weapon("beginner's sword", "physical", 50), 20);
                return knight;
            }
            else
            {
                WizardHpMp();
                Wizard wizard = new Wizard(name, 1, hp, mp, new Weapon("beginner's wand", "magic", 50), "fire");
                return wizard;
            }

        }

        private static string getName()
        {
            while(true)
            {
                name = ReadLine();
                if (name == null)
                    WriteLine("Please type a name");
                else
                    break;
            }
            return name;
        }

        private static void KnightHpMp()
        {
            WriteLine("Roll the d20 to find out your HP");
            hp = Convert.ToInt32(ReadLine()) * 5 + 100;

            WriteLine("Roll the d20 to find out your MP");
            mp = Convert.ToInt32(ReadLine()) * 2 + 20;
        }
        private static void WizardHpMp()
        {
            WriteLine("Roll the d20 to find out your HP");
            hp = Convert.ToInt32(ReadLine()) * 3 + 80;

            WriteLine("Roll the d20 to find out your MP");
            mp = Convert.ToInt32(ReadLine()) * 5 + 100;
        }
    }
}