using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TaranIV.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y; //false
            res[1] = x != y; //true
            res[2] = x < y; // true
            res[3] = x + 150 > y; // true
            res[4] = x + 150 <= y; // flase
            res[5] = x + 150 >= y; // true

            return res;
        }
    }
}