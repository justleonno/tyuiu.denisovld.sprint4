using tyuiu.cources.programming.interfaces.Sprint4;
namespace tyuiu.denisovld.sprint4.Task5.V29.Lib
{
    public class DataService : ISprint4Task5V29
    {

        public int Calculate(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < (matrix.Length / matrix.GetLength(0)); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
