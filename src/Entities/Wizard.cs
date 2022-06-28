namespace Abstracao_RPG_POO.src.Entities {
    public class Wizard : Hero {
        public Wizard(string name, int level, string heroType, int HP, int fullHP, int MP, int fullMP) : base(name, level, heroType, HP, fullHP, MP, fullMP) {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.fullHP = fullHP;
            this.MP = MP;
            this.fullMP = fullMP;
        }

        public override string Attack() {
            return $"{this.name} lançou uma magia";
        }
    }
}