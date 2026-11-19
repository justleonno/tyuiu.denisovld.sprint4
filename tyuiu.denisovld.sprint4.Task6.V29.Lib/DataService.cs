using tyuiu.cources.programming.interfaces.Sprint4;
namespace tyuiu.denisovld.sprint4.Task6.V29.Lib
{
    public class DataService : ISprint4Task6V29
    {
        public int Calculate(string[] array)
        {
            int count = (Array.FindAll(array, n => n.Length > 4)).Length;
            return count;
            
        }
    }
}
