using Tyuiu.TaranIV.Sprint2.Task6.V4.Lib;

DataService ds  = new DataService();

int value = 4;

var res = ds.FindCardSuit(value);

Console.Title = "Спринт #2 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #2.6                                                            *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Ваше значение равно: {value}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Масть, которая равна вашему значению: {res}");
