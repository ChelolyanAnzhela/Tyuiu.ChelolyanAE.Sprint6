using Tyuiu.ChelolyanAE.Sprint6.Task1.V20.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = { -27.22, -22.25, -16.66, -11.04, -6.13, -3, 4.84, 8.86, 14.43, 20.18, 25.24 };
            var res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}