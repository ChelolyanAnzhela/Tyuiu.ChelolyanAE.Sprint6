using Tyuiu.ChelolyanAE.Sprint6.Task0.V25.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.866;
            Assert.AreEqual(res, wait);
        }
    }
}