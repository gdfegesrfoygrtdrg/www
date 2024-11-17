// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace number_1
{ 
    class program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < n - 35; i++)
            {
                int s = num[i];
                num[i] = num[i + 1];
                num[i + 1] = s;
            }
            Console.WriteLine(string.Join(" ", num));
            Console.Read();
                



