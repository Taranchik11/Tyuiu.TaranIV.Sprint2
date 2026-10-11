using Tyuiu.TaranIV.Sprint2.Task4.V5.Lib;

namespace Tyuiu.TaranIV.Sprint2.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = -4;
            double wait = -64;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 5;
            double y = 15;
            double wait = 75.067;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);

        }
    }
}
