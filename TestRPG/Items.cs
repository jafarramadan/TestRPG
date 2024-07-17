using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestRPG
{
    public abstract class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //public Items(string name,string description)
        //{
        //    Name = name;
        //    Description = description;
        
        //}
    }

    public class Weapon : Items
    {
       public int attackBoost { get; set; }
        

    }
    public class Armor : Items
    {
        public int defenseBoost { get; set; }
        
    }
    public class Potion : Items 
    {
        public int healthBoost { get; set; }

        
        
    }
}
