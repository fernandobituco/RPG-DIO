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

        public virtual string Attack(Character enemy)
        {
            return ($"{this.Name} attacked {enemy.Name}");
        }

        public Character(string Name, int Level, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpMax = Hp;
            this.HpCurrent = Hp;
            this.MpMax = Mp;
            this.MpCurrent = Mp;
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
    }
}