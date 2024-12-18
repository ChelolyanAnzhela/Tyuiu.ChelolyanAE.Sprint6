using Tyuiu.ChelolyanAE.Sprint6.Task4.V13.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] wait = { -9.10, 1.55, 292.78, -0.57, -0.35, 2, 4.35, 4.57, -288.78, 2.45, 13.10 };
            var res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}