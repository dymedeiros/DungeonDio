using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonDio.src.Entities
{
    public class Fighter : Hero
    {
        public Fighter(string name, int level, string heroType)
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
            if(bonus > 8){
                return this.Name + " Atacou com uma voadora com um bonus de " + bonus;
            }else{
                return this.Name + " Atacou com um soco com um bonus de " + bonus;
            }
        }  
    }
}