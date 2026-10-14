using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TaranIV.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            // Проверка на корректность ввода (базовая)
            if (m < 1 || m > 12 || n < 1 || n > 31)
                return "Некорректная дата";

            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            // Если это первое число месяца
            if (n == 1)
            {
                // Если это январь, переходим на декабрь прошлого года
                if (m == 1)
                {
                    prevDay = 31;
                    prevMonth = 12;
                    prevYear = g - 1;
                }
                else
                {
                    // Переходим на предыдущий месяц
                    prevMonth = m - 1;

                    // Определяем количество дней в предыдущем месяце
                    switch (prevMonth)
                    {
                        case 2: // Февраль (по условию год високосный)
                            prevDay = 29;
                            break;
                        case 4: // Апрель
                        case 6: // Июнь
                        case 9: // Сентябрь
                        case 11: // Ноябрь
                            prevDay = 30;
                            break;
                        default: // Все остальные месяцы (1, 3, 5, 7, 8, 10)
                            prevDay = 31;
                            break;
                    }
                }
            }

            // Возвращаем полную дату в виде строки
            return $"{prevDay:D2}.{prevMonth:D2}.{prevYear}";
        }
    }
}
