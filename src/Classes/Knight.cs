namespace RPG_DIO.src.Classes
{
    public class Knight : Character
    {
        public string Weapon { get; set; }

        public Knight(string Name, int Level, int Hp, int Mp, string Weapon) : base(Name, Level, Hp, Mp)
        {
            this.Weapon = Weapon;
        }

        public override string Attack(Character enemy)
        {
            return ($"{this.Name} attacked {enemy.Name} with his {this.Weapon}");
        }
    }
}