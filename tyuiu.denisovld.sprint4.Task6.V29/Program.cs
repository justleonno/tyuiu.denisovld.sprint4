using System.ComponentModel;
using tyuiu.denisovld.sprint4.Task6.V29.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #4                                                                                     *");
Console.WriteLine("* Тема: Klass Array                                                                             *");
Console.WriteLine("* Задание #6                                                                                    *");
Console.WriteLine("* Вариант #29                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Дан строковый массив данных [\"Весна\", \"Лето\", \"Осень\", \"Зима\"]                        *");
Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых больше 4.               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

string[] lol = { "Весна", "Лето", "Осень", "Зима" };

Console.WriteLine(ds.Calculate(lol));
Console.ReadKey();




