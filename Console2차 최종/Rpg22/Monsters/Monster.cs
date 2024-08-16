using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22.Monsters
{
    public class Monster
    {
        private int id;
        public string name;
        public int hp;
        public int attack;



        public Monster(int id)
        {
            this.id = id;
            this.name = "몬스터";
            this.hp = 100;
            this.attack = 30;
        }

        public void TakeDamage(int damege)
        {
            hp-=damege;
            Console.WriteLine($"{name} 이/가 데미지 {damege}를 받아 {hp}이 되었습니다.");
            if (hp <= 0)
            {
                Die();
            }
        }
        public void Die()
        {
            Console.WriteLine($"{name} 이/가 쓰러집니다.");
        }

    }
    public class Pennir : Monster
    {
        public Pennir(int id) : base(id)
        {
            name = "펜리르";
            hp = 100;
            attack = 30;
        }

        public void Skil1()
        {
            Console.WriteLine($"{name} 가 스킬을 사용합니다.");
        }
    }

    public class Jormungand : Monster
    {
        public Jormungand(int id) : base(id)
        {
            name = "요르문간드";
            hp = 100;
            attack = 25;
        }

        public void Skil2()
        {
            Console.WriteLine($"{name} 가 스킬을 사용합니다.");
        }
    }

    public class Yotun : Monster
    {
        public Yotun(int id) : base(id)
        {
            name = "요툰";
            hp = 100;
            attack = 1;
        }

        public void Skil3()
        {
            Console.WriteLine($"{name} 가 스킬을 사용합니다.");
        }
    }

    public class Damagereceived
    {
        private int attack;

        public Damagereceived()
        {
            attack = 3;
        }

        public void Attack(Monster monster)
        {
            monster.TakeDamage(attack);
        }

        public  static void Main1123()
        {
            Damagereceived damagereceived = new Damagereceived();

            Pennir pennir = new Pennir(1);
            Jormungand jormungand = new Jormungand(2);
            Yotun yotun = new Yotun(3);

            Damagereceived.
        }
    }       
}
