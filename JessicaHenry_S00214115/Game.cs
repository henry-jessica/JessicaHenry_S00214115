﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessicaHenry_S00214115
{
    public class Game
    {
        //properties 
        
       public string Name { get; set; }
       public decimal MetacriticScore { get; set; }
       public string Description { get; set; }
       public string Platform { get; set; }
       public decimal Price { get; set; }
       public string Game_Image { get; set; }
     
        //constructors 

        //methods
        public void DecreasePrice(decimal amountToDecrease)
        {
            Price -= amountToDecrease;
        }
    }//end of Game class

    public class GameData : DbContext
    {
        public GameData() : base("MyGameData0001") { }
        public DbSet<Game> Games { get; set; }

    }
}
