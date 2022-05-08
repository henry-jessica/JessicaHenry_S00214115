using Microsoft.VisualStudio.TestTools.UnitTesting;
using JessicaHenry_S00214115; 
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Game_DecreasePrice()
        {
            //ARRANGE 
            Game g1 = new Game() { Name = "Minecraft", Price=50m};
            decimal priceExpeted = 40m;

            //ACT 
            g1.DecreasePrice(10m);

            //ASSERT
            Assert.AreEqual(priceExpeted, g1.Price); 

        }
    }
}