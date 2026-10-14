using Tyuiu.TaranIV.Sprint2.Task5.V12.Lib;

namespace Tyuiu.TaranIV.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            int g = 2025;
            int m = 12;
            int n = 31;
            var res = ds.FindDateOfPreviousDay(g, m, n);
            var wait = "30.12.2025";
            Assert.AreEqual(wait, res);
        }
    }
}
