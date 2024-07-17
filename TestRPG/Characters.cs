using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRPG
{
    public class Player : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public int OriginalHealth { get; set; }
        public Inventory Inventory { get; set; }

        public Player()
        {
            Name = "jafar";
            Health = 100;
            AttackPower = 25;
            Defense = 15;
            OriginalHealth = 100;
            Inventory = new Inventory();
        }

        //public void UseItemes(Items items)
        //{
        //    if (items is Weapon weapon)
        //    {
        //        AttackPower += weapon.attackBoost;
        //    }
        //    else if (items is Armor armor)
        //    {
        //        Defense += armor.defenseBoost;
        //    }
        //    else if (items is Potion potion)
        //    {
        //        Health += potion.healthBoost;
        //    }

        //    }
    }

        public abstract class Monster : IBattleStates
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int Defense { get; set; }

            public int OriginalHealth { get; set; }



            public Monster(string name, int health, int attackPower, int defense, int originalHealth)
            {
                Name = name;
                Health = health;
                AttackPower = attackPower;
                Defense = defense;
                OriginalHealth = Health;
            }
        }

        public class Zombi : Monster
        {
            public Zombi() : base("Zombi", 101, 20, 10, 101) { }

        }

        public class Vampire : Monster
        {
            public Vampire() : base("Vampire", 102, 20, 10, 102) { }

        }

        public class Goblin : Monster
        {
            public Goblin() : base("Goblin", 103, 20, 10, 103) { }

        }

        public class BossMonster : Monster
        {
            public BossMonster() : base("BossMonster", 150, 50, 25, 150)
            {

            }
        }

    }




