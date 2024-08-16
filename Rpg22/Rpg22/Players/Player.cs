﻿using Rpg22.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22.Players
{
    public abstract class Player
    {
        protected string name;
        public string Name { get { return name; } }

        protected Job job;
        public Job Job { get { return job; } }

        protected int curHP;
        public int CurHP { get { return curHP; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; } }

        protected int attack;
        public int Attack { get { return attack; } }

        protected int defense;
        public int Defense { get { return defense; } }

        protected int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        public abstract void Skill(Monster monster);

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("==========================================");
            Console.WriteLine($" 이름 : {name,-6} 직업 : {job,-6}");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP}  공격 : {attack,-3} / 방어 : {defense,-3}");
            Console.WriteLine($" 골드 : {gold,+5} G");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }
    }
}
