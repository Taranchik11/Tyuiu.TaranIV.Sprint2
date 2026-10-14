using Tyuiu.TaranIV.Sprint2.Task5.V12.Lib;

DataService ds  = new DataService();

int g = 2028, m = 01, n = 01;

var res = ds.FindDateOfPreviousDay(g, m, n);

Console.Title = "Спринт #2 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор Switch                                                   *");
Console.WriteLine("* Задание #2.5                                                            *");
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

Console.WriteLine($"Текущий год:  + {g}");
Console.WriteLine($"Текущий месяц:  + {m}");
Console.WriteLine($"Текущий день:  + {n}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Дата предыдущего дня: + {res}");

Console.ReadKey();