using Tyuiu.TaranIV.Sprint2.Task4.V5.Lib;

DataService ds = new DataService();

double x;
double y;
double res;

Console.Title = "Спринт #2 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #2.4                                                            *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит значения *");
Console.WriteLine("* переменной X и Y с клавиатуры.                                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Введите значение переменной x = ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной y = ");
y = Convert.ToDouble(Console.ReadLine());

res = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции: " + res);

Console.ReadKey();
