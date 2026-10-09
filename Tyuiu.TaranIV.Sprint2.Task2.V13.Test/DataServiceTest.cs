using Tyuiu.TaranIV.Sprint2.Task2.V13.Lib;

namespace Tyuiu.TaranIV.Sprint2.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckPointInShadedArea()
        {
            DataService ds = new DataService();

            int x = 15;
            int y = 6;

            var res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
