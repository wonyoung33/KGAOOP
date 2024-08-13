using Rpg22.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22.Players
{
    public class Warrior : Player
    {
        public Warrior(string name)
        {
            this.name = name;
            this.job = Job.Warrior;
            this.maxHP = 120;
            this.curHP = maxHP;
            this.attack = 30;
            this.defense = 30;
            this.gold = 0;
        }

        public override void Skill(Monster monster)
        {
            // TODO : 스킬 구현
        }
    }
}
