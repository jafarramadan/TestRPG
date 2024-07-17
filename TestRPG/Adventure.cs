using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRPG
{
    public class Adventure
    {
        Player player=new Player();
        List<Monster> monsters;

       static List<string> locations = new List<string>() { 
            "Town","Cave","City","Park"
        };
        string currentLocation = locations[0];

        public Adventure(Player player) 
        {
            this.player = player;
            monsters = new List<Monster>() {
            new Zombi(),new Vampire(),new Goblin(),new BossMonster()
        };
        }
        public  void Action()
        {
            while (true)
            {
                Console.WriteLine($"You are in {currentLocation}");
                Console.WriteLine("Choose an action : ");
                Console.WriteLine("1-Change the location \n2-Start adventure\n3-Veiw inventory\n4-End game");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        DisplayLocation();
                        continue;

                    case "2":
                        StartAdventure();
                        continue;

                    case "3":
                        Console.WriteLine("moayad1");
                        VeiwItemes();
                        continue;

                    case "4":
                        EndGame();
                        break;
                }
            }
        }

        public  string DisplayLocation()
        {
            int count = 0;
            for (int i = 0; i < locations.Count; i++)
            {
                count++;
                Console.WriteLine($"{count}-{ locations[i]}");
            }
            Console.WriteLine("Enter the location number");
           int num=int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    currentLocation = locations[0];
                    break;
                case 2:
                    currentLocation = locations[1];
                    break;
                case 3:
                    currentLocation = locations[2];
                    break;
                case 4:
                    currentLocation = locations[3];
                    break;
            }

        return currentLocation;
        }

        public  void StartAdventure()
        {
            Random random = new Random();
            Player player = new Player();

            int rand=random.Next(monsters.Count);
            Monster RandomMonster= monsters[rand];
            BattleSystem battleSystem = new BattleSystem();

            battleSystem.StartBattle(player, RandomMonster);

        }

        public  void EndGame()
        {
            Console.WriteLine("The end...");
            Environment.Exit(0);
        }
        
        public  void VeiwItemes()
        {
            Console.WriteLine("moayad2");
            BattleSystem battleSystem = new BattleSystem();
            Inventory inventory = new Inventory();
            battleSystem.DisplayItemes();
            //if (battleSystem.items.Count > 0)
            //{
                //Console.WriteLine("Enter the item number");
                //int num = Convert.ToInt32(Console.ReadLine());
                //string item = battleSystem.items[num -1];
               // player.UseItemes(item);
           // }
            //else
            //{
            //    Console.WriteLine("alooooooooooooooooooo");
            //}
        }
    }
    }

