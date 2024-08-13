using Rpg22.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22.Players
{
    public class Rogue : Player
    {
        public Rogue(string name)
        {
            this.name = name;
            this.job = Job.Rogue;
            this.maxHP = 80;
            this.curHP = maxHP;
            this.attack = 40;
            this.defense = 20;
            this.gold = 0;
        }

        public override void Skill(Monster monster)
        {
            // TODO : 스킬 구현
        }
    }
}
