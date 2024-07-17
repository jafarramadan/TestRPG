namespace TestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();   
            Monster zombi= new Zombi();
            Adventure adv=new Adventure(player);

            // BattleSystem.StartBattle(player, zombi);

            adv.Action();
        }
    }
}
