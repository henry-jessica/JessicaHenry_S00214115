using JessicaHenry_S00214115;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add reference to database
            GameData db = new GameData();

            using (db)
            {
                Game g1 = new Game()
                {
                    Name = "It Takes Two",
                    Platform = "PC, Xbox, PS, Switch",
                    MetacriticScore = 88.8m,
                    Price = 69.99m,
                    Description = "Description of the game"
                };
                Game g2 = new Game()
                {
                    Name = "Resident Evil",
                    Platform = "PC, Xbox, Switch",
                    MetacriticScore = 98.8m,
                    Price = 169.99m,
                    Description = "Resident and Evil"
                };
                Game g3 = new Game()
                {
                    Name = "Miles Morales",
                    Platform = "PS",
                    MetacriticScore = 75.8m,
                    Price = 149.99m,
                    Description = "Description of the game Miles Morales"
                };

                Console.WriteLine("Games Have been created");

                db.Games.Add(g1);
                db.Games.Add(g1);
                db.Games.Add(g1);
                db.Games.Add(g1);

                Console.WriteLine("Games have been added to table");

                db.SaveChanges();
                Console.WriteLine("Data has been saved to DB, hit enter to continue");
                Console.ReadLine(); 
            }
        }
    }
}
