using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChelolyanAE.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[] column = new int[columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    if (j == 0)
                    {
                        column[i] = matrix[i, j];
                    }
            }
            Array.Sort(column);

            for (int i = 0; i < rows; i++)
            {
                for(int j=0; j<columns; j++)
                if (j == 0)
                {
                    matrix[i, j] = column[i];
                }
            }
            return matrix;
        }
    }
}
