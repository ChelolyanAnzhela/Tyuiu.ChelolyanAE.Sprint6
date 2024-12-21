using Tyuiu.ChelolyanAE.Sprint6.Task6.V30.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "";
            string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = "PAlR qdsTS zgGQ XVZeHq dwMQ";
            Assert.AreEqual(wait, res);
        }
    }
}