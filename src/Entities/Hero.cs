namespace Abstracao_RPG_POO.src.Entities {
    public abstract class Hero {
        public string name, heroType;
        public int level, HP, fullHP, MP, fullMP;

        public Hero(string name, int level, string heroType, int HP, int fullHP, int MP, int fullMP) {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.fullHP = fullHP;
            this.MP = MP;
            this.fullMP = fullMP;
        }

        public override string ToString() {
            return $"Hero: {name} Level: {level} Type: {heroType} \nHP: {HP}/{fullHP} \nMP: {MP}/{fullMP}";
        }

        public virtual string Attack() {
            return $"{this.name} atacou";
        }

        public virtual string Attack(int bonus) {
            if(bonus > 6) {
                return $"{this.name} fez um ataque efetivo, com um bonus de ataque de {bonus}";
            } else {
                return $"{this.name} fez um ataque fraco, com um bonus de ataque de {bonus}";
            }
        }
    }
}