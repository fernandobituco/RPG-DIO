namespace RPG_DIO.src.Classes
{
    public class Weapon
    {
        public Weapon(string name, string type, int damage)
        {
            this.Name = name;
            this.Type = type;
            this.Damage = damage;

        }

        public string Name { get; set; }
        
        public string Type { get; set; }

        public int Damage { get; set; }
    }

}