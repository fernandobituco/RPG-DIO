namespace RPG_DIO.src.Classes
{
    public abstract class Character
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public int HpMax { get; set; }
        public int HpCurrent { get; set; }
        public int MpMax { get; set; }
        public int MpCurrent { get; set; }
        public bool IsAlive { get; set; }
        public int Damage = 10;

        public virtual bool Attack(Character enemy)
        {
            Console.WriteLine ($"{this.Name} attacked {enemy.Name}");
            return checkLife(enemy);
        }

        public Character(string Name, int Level, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpMax = Hp;
            this.HpCurrent = Hp;
            this.MpMax = Mp;
            this.MpCurrent = Mp;
            this.IsAlive = true;
        }

        public override string ToString()
        {
            return ($@" Character status
                Name: {this.Name}
                Level: {this.Level}
                HP: {this.HpCurrent}/{this.HpMax}
                MP: {this.MpCurrent}/{this.MpMax}
            ");
        }

        public int damage(Character attacker, Character defender)
        {
            Random rnd = new Random();
            int damageDealt = Damage * attacker.Level * rnd.Next(1,6) / 10;
            defender.HpCurrent -= damageDealt;
            return damageDealt;
        }

        public static bool checkLife(Character defender)
        {
            if (defender.HpCurrent <= 0)
            {
                defender.IsAlive = false;
                Console.WriteLine($"{defender.Name} DIED");
                return false;
            }
            else
            {
                Console.WriteLine($"{defender.Name} has {defender.HpCurrent} HP");
                return true;
            }
        }
    }
}