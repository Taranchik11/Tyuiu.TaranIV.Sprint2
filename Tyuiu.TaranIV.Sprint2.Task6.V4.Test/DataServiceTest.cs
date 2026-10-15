using Tyuiu.TaranIV.Sprint2.Task6.V4.Lib;

namespace Tyuiu.TaranIV.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindCard()
        {
            DataService ds = new DataService();

            int value = 1;

            var res = ds.FindCardSuit(value);

            Assert.AreEqual("Пики", res);

        }
    }
}
