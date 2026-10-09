using Tyuiu.TaranIV.Sprint2.Task3.V27.Lib;

namespace Tyuiu.TaranIV.Sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 5;
            var res = ds.Calculate(x);
            double wait = 24.462;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            var res = ds.Calculate(x);
            double wait = 0.25;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = -20;
            var res = ds.Calculate(x);
            double wait = 1.005;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -50;
            var res = ds.Calculate(x);
            double wait = -125048.982;

            Assert.AreEqual(wait, res);
        }
    }
}
