using tyuiu.denisovld.sprint4.Task1.V1.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #4                                                                                     *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                                  *");
Console.WriteLine("* Задание #1                                                                                    *");
Console.WriteLine("* Вариант #1                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями       *");
Console.WriteLine("* в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.                       *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int len;
Console.WriteLine("Введите количество элементов в массиве");
len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
for (int i  = 0; i < len; i++)
{
    Console.WriteLine("Введите " + i + "-й элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine(ds.Calculate(array));
Console.ReadKey();





