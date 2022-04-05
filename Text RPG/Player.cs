using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Player
    {
        public string name ="Route0827";
        public int str = 5;
        public int luk = 3;
        public int dex = 3;
        public int def = 3;
        public int Intelligence = 1;
        public int level = 1;
        public int max_hp = 10;
        public int current_hp = 10;
        public int max_mp = 10;
        public int current_mp = 10;
        public int gold = 0;
        public int max_exp = 20;
        public int current_exp = 0;

        public void information()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("플레이어 이름: " + " 『 " + name+ "』");
            Console.WriteLine("Gold : " + gold + "G ");
            Console.WriteLine("EXP : " + current_exp + "/" + max_exp + "EXP ");
            Console.WriteLine("Lv : " + level);
            Console.WriteLine("------------------------------");
            Console.WriteLine("str : " + str );
            Console.WriteLine("luk : " + luk );
            Console.WriteLine("dex : " + dex);
            Console.WriteLine("def : " + def);
            Console.Write("int : " + Intelligence + "\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("방어력 : " + def + "  ");
            Console.WriteLine("체력 : " + current_hp +"/" + max_hp + "  ");
            Console.WriteLine("마나 : " + current_mp + "/" + max_mp + "   ");
            Console.WriteLine("==============================");


        }
        public void fight(Monster_1 monster)
        {
            while(true)
            {
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("============== 내 턴 ==============");
                if (monster.def >= str)
                {
                    monster.current_hp -= 1;
                    Console.WriteLine(name + "이 몬스터 " + monster.name + "에게" + 1 + "만큼의 데미지를 입혔습니다.");
                }

                else
                {
                    monster.current_hp -= (str - monster.def);
                    Console.WriteLine(name + "이 몬스터 " + monster.name + "에게" + (str - monster.def) + "만큼의 데미지를 입혔습니다.");
                }
                information();
                monster.information();
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("============== 상대 턴 ==============");
                if (def >= monster.atk_dmg)
                {
                    current_hp -= 1;
                    Console.WriteLine(monster.name + "이 " + name + "에게" + 1 + "만큼의 데미지를 입혔습니다.");
                }
                else
                {
                    current_hp -= (str - monster.def);
                    Console.WriteLine(monster.name + "이 " + name + "에게" + (monster.atk_dmg - def) + "만큼의 데미지를 입혔습니다.");
                }

                information();
                monster.information();

                if (current_hp <= 0) //플레이어의 체력이 0보다 낮다면
                {
                    Console.WriteLine("사망하셨습니다.");
                    Console.ReadLine();
                    return;
                }
                else if (monster.current_hp <= 0) //몬스터의 체력이 0보다 낮다면
                {
                    Console.WriteLine("몬스터" + monster.name + "을" + "물리쳤습니다.");
                    monster.itemdorp(this);
                    Console.ReadLine();
                    return;
                }
            }
        }

    }
            
           

    
}
