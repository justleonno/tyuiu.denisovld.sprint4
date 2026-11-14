using System.ComponentModel;
using tyuiu.denisovld.sprint4.Task2.V9.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();
Random rnd = new Random();

Console.Title = "Спринт 4 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #4                                                                                     *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                                   *");
Console.WriteLine("* Задание #0                                                                                    *");
Console.WriteLine("* Вариант #16                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями       *");
Console.WriteLine("* в диапазоне от 0 до 9 подсчитать произведение четных элементов массива.                       *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int[] lol = new int[14];

for (int i = 0; i < lol.Length; i++)
    lol[i] = rnd.Next(1, 7);


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine(ds.Calculate(lol));
Console.ReadKey();





