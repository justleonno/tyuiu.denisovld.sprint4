using tyuiu.cources.programming.interfaces.Sprint4;
namespace tyuiu.denisovld.sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[(array.Length / array.GetLength(0))-1, i] > max)
                {
                    max = array[(array.Length / array.GetLength(0))-1, i];
                }
            }
            return max;
        }
    }
}
