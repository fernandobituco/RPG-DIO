namespace RPG_DIO.src.Classes
{
    public class Wizard : Character
    {    
        public string Element { get; set; }
        public Wizard(string Name, int Level, int Hp, int Mp, string Element) : base(Name, Level, Hp, Mp)
        {
            this.Element = Element;
        }

        public override bool Attack(Character enemy)
        {
            int damageDealt = this.damage(this, enemy);
            Console.WriteLine($"{this.Name} attacked {enemy.Name} using a {this.Element} spell dealing {damageDealt} damage");
            return checkLife(enemy);
        }
    }
}