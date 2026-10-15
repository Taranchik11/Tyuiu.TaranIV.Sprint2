using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TaranIV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y == Math.Pow(x, 2)) || (y == 2 - x))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
