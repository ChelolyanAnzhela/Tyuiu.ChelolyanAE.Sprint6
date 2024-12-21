using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChelolyanAE.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resstr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(" ");
                    if (array[3] == "")
                    {
                        break;
                    }
                    resstr += array[3] + " ";
                }

            }

            return resstr.Trim();
        }
    }
}
