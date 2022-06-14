namespace RPG_DIO.src.Classes
{
    public class Knight : Character
    {
        public int Strength { get; set; }

        public Knight(string Name, int Level, int Hp, int Mp, Weapon weapon, int Strength) : base(Name, Level, Hp, Mp, weapon)
        {
            this.Strength = Strength;
        }

        public override bool Attack(Character enemy)
        {
            int damageDealt = this.damage(this, enemy);
            Console.WriteLine ($"{this.Name} attacked {enemy.Name} with his {this.weapon} dealing {damageDealt} damage");
            return checkLife(enemy);       
        }
    }
}