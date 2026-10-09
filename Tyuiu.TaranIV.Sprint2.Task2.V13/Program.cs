using Tyuiu.TaranIV.Sprint2.Task2.V13.Lib;

DataService ds = new DataService();
bool res;
int x, y;

Console.Title = "Спринт #2 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if                                                       *");
Console.WriteLine("* Задание #2.2                                                            *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
Console.WriteLine("* в заштрихованной области.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной x: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной y: ");
y = Convert.ToInt32(Console.ReadLine());

res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области");
}
else 
{
    Console.WriteLine("Точка не находиться в заштрихованной области");

}

Console.ReadKey();