using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonDio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou sua magia";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6){
                return this.Name + " lançou sua magia super efetiva com bonus de ataque de " + bonus;
            }else{
                return this.Name + " lançou sua magia com bonus de ataque de " + bonus;
            }

            
        }
    }
}