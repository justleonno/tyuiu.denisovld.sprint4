using System.ComponentModel;
using tyuiu.denisovld.sprint4.Task5.V29.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();
Random rnd = new Random();
Console.Title = "Спринт 4 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #4                                                                                     *");
Console.WriteLine("* Тема: Двумерные массивы (ввод с клавы)                                                        *");
Console.WriteLine("* Задание #4                                                                                    *");
Console.WriteLine("* Вариант #24                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный статическими значениями       *");
Console.WriteLine("* в диапазоне от 5 до 9. заменить четные числа на 1                                             *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int rows = 0;
Console.WriteLine("Введите количество символов в строке массива");
rows = Convert.ToInt32(Console.ReadLine());
int columns = 0;
Console.WriteLine("Введите количество символов в столбце массива");
columns = Convert.ToInt32(Console.ReadLine());

int[,] lol = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        lol[i, j] = rnd.Next(-9, 9);

    }
}

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

int counter = 0;
counter = ds.Calculate(lol);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{lol[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine(ds.Calculate(lol));
Console.WriteLine(counter);
Console.ReadKey();





