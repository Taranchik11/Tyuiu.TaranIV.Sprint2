using Tyuiu.TaranIV.Sprint2.Task7.V12.Lib;

namespace Tyuiu.TaranIV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDot()
        {
            DataService ds = new DataService();

            int x = 10;
            int y = 100;

            bool res = ds.CheckDotInShadedArea(x, y);
            
            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}
