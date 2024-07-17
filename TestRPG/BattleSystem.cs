using System;
using System.Collections.Generic;


namespace TestRPG
{
    public class BattleSystem
    {
        public string[] listRaghad = new string[1];
        public void Attack(IBattleStates attacker, IBattleStates target)
        {
            int damage = attacker.AttackPower - target.Defense;
            damage = damage > 0 ? damage : 0;
            target.Health -= damage;
            target.Health = target.Health > 0 ? target.Health : 0;

            Console.WriteLine($" {attacker.Name} attackes {target.Name} ,with damage dealt = {damage} , {target.Name} health = {target.Health} ");

        }

        public  void StartBattle(Player player, Monster enemy)
        {

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine($"{player.Name} turn :");
                Attack(player, enemy);

                if (enemy.Health > 0)
                {
                    Console.WriteLine($"{enemy.Name} turn :");
                    Attack(enemy, player);
                }
            }
            if (player.Health <= 0)
            {
                Console.WriteLine($"{enemy.Name} defeated {player.Name}");
                player.Health = player.OriginalHealth;
            }
            else if (enemy.Health <= 0)
            {
                Console.WriteLine($"{player.Name} defeated {enemy.Name}");
                HandleItemes(player);
                enemy.Health = enemy.OriginalHealth;
            }
        }
        public List<string> ItemsList= new List<string>();
        
        public  void HandleItemes(Player player)
        {
            Random random = new Random();
           
            int equipNum = random.Next(0, 2);

            if (equipNum == 1)
            {
                Items newItem= RandomPickItem();
                
                Console.WriteLine($"*{newItem.Name}* added to your inventory ");

                listRaghad.Append("aya");

            }
            else
            {
                Console.WriteLine("no itemes added!");
            }
        }

        public  Items RandomPickItem()
        {
            Random random = new Random();
            int trueFalseNum = random.Next(0, 3);
            switch (trueFalseNum)
            {
                case 0:
                    return new Weapon { Name = "Gun", Description = "Contains lethal lead", attackBoost = 10 };

                case 1:
                    return new Armor { Name = "Shield", Description = "Provide safety", defenseBoost = 5 };

                case 2:
                    return new Potion { Name = "Health Dose", Description = "Increases health", healthBoost = 20 };
                default:
                    return null;
                    
            }
        }
        public void DisplayItemes()
        {
            // BattleSystem battleSystem = new BattleSystem();

            //if (battleSystem.items.Count >= 0)
            //{
            //for (int i = 0; i < items.Count; i++)
            //{

            //    Console.WriteLine($"{count}-{items[i]}");
            //}
            Console.WriteLine("moayad3");
            foreach (string i in listRaghad)
            {
                Console.WriteLine("moayad4");
                Console.WriteLine(i);
            }
            //}
            //else { Console.WriteLine("empty"); }


        }
    }
}
    
