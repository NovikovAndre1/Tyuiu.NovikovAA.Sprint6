
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NovikovAA.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader rd = new StreamReader(path))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    string[] str = line.Split(" ");
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].Contains("H"))
                        {
                            res += str[i] + " ";
                        }
                    }
                }
            }
            res = res.Trim();
            return res;
        }
    }
}
