using System.ComponentModel;
using tyuiu.denisovld.sprint4.Task7.V29.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #4                                                                                     *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                       *");
Console.WriteLine("* Задание #6                                                                                    *");
Console.WriteLine("* Вариант #29                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"983157642891\".                                           *");
Console.WriteLine("* Преобразуйте ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.                            *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

string lol = "983157642891";

Console.WriteLine(ds.Calculate(4, 3, lol));
Console.ReadKey();




