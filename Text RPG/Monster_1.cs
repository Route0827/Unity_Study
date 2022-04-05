using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Monster_1
    {
        public string name ="슬라임";
        public int level = 1;
        public int atk_dmg = 1;
        public int def = 2;
        public int max_hp = 15;
        public int current_hp = 15;
        public int drop_gold = 10;
        public int drop_exp = 10;
        public void information()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(" 『 " + name + "』");
            Console.WriteLine("Lv : " + level);
            Console.WriteLine("------------------------------");
            Console.WriteLine("atk_dmg : " + atk_dmg);
            Console.WriteLine("def : " + def);
            Console.WriteLine("------------------------------");
            Console.WriteLine("방어력 : " + def + "  ");
            Console.WriteLine("체력 : " + current_hp + "/" + max_hp + "  ");
            Console.WriteLine("==============================");


        }

       public void itemdorp(Player player)
        {
            player.gold += drop_gold;
            player.current_exp += drop_exp;
            if (player.current_exp >= 10) ;
            {
                player.level += 1;
            }

            Console.ReadLine();
            Console.Clear();
            information();
            player.information();
        }
    }
    
}
