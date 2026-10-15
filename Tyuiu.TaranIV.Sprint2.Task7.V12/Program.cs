using Tyuiu.TaranIV.Sprint2.Task7.V12.Lib;

DataService ds = new DataService();

double x = 0;
double y = 0;

bool result;

Console.Title = "Спринт #2 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #2.7                                                            *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка                 *");
Console.WriteLine("* с координатами X,Y в заштрихованной области.                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
y = Convert.ToDouble(Console.ReadLine());

result = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (result == true)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else 
{
    Console.WriteLine("Точка не находится в заштрихованной области. Вы указали неверные данные");
}

Console.ReadKey();