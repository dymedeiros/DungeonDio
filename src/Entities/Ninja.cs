using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonDio.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua Katana";
        }

        public string Attack(int bonus)
        {
            if(bonus > 5){
                return this.Name + " Atacou com sua Katana com um bonus de " + bonus;
            }else{
                return this.Name + " Atacou com uma shuryken com um bonus de " + bonus;
            }
        }             
    }
}