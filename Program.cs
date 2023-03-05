internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Введите размерность массива;");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] b = new int[n];
        Console.WriteLine("Введите все числа массива(целочисленные)");
        for (int i = 0; i < n; i++)
        {
            b[i]= Convert.ToInt32(Console.ReadLine());
        }
        
        for (int i = 1; i < b.Length ; i++)
        {
            int k = b[i];
            int j = i - 1;

            while (j >= 0 && b[j] > k)
            {
                b[j + 1] = b[j];
                b[j] = k;
                j--;
            }
        }

        Console.WriteLine("Результат:");
        for (int i = 0; i < b.Length; i++)
        {
            if (i == b.Length - 1)
            {
                Console.Write(b[i]);
            }
            else
            {
                Console.Write(b[i] + ", ");
            }
        }
    }
}