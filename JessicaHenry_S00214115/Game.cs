﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessicaHenry_S00214115
{
    public class Game
    {
       public string Name { get; set; }
       public decimal MetacriticScore { get; set; }
       public string Description { get; set; }
       public string Platform { get; set; }
       public decimal Price { get; set; }
       public string Game_Image { get; set; }
     
        public void DecreasePrice(int desc)
        {
            Price -= desc;
        }
    }
}
