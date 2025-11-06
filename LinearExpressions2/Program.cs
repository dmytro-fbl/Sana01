internal class Program
{
    private static void Main(string[] args)
    {
        double resultZ1, resultZ2, resultY, oneDil, twoDil, a, b, m, n, x;
        bool good;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        do
        {
            Console.WriteLine("Введіть число a");
            good = double.TryParse(Console.ReadLine(), out a);
            if (!good)
            {
                Console.WriteLine("Ви ввели не число");
            }
        } while (!good);
        do
        {
            Console.WriteLine("Введіть число a");
            good = double.TryParse(Console.ReadLine(), out b);
            if (!good)
            {
                Console.WriteLine("Ви ввели не число");
            }
        } while (!good);
        do
        {
            Console.WriteLine("Введіть число b");
            good = double.TryParse(Console.ReadLine(), out m);
            if (!good)
            {
                Console.WriteLine("Ви ввели не число");
            }
        } while (!good);
        do
        {
            Console.WriteLine("Введіть число m");
            good = double.TryParse(Console.ReadLine(), out n);
            if (!good)
            {
                Console.WriteLine("Ви ввели не число");
            }
        } while (!good);
        do
        {
            Console.WriteLine("Введіть число x");
            good = double.TryParse(Console.ReadLine(), out x);
            if (!good)
            {
                Console.WriteLine("Ви ввели не число");
            }
        } while (!good);


        oneDil = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n);
        twoDil = Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m;
        resultZ1 = oneDil / twoDil;

        Console.WriteLine($"Результат прикладу Z1: {resultZ1:F3}");

        oneDil = Math.Sqrt(m) - Math.Sqrt(n);
        twoDil = m;
        resultZ2 = oneDil / twoDil;
        Console.WriteLine($"Результат прикладу Z2: {resultZ2:F3}");

        double sinZnach = a - b;
        oneDil = 2.4 * (Math.Abs((Math.Pow(x, 2) + b) / a));
        twoDil = (a - b) * Math.Pow(Math.Sin(sinZnach), 2);
        double threeDil = Math.Pow(10, -2) * (x - b);
        resultY = oneDil + twoDil + threeDil;

        Console.WriteLine($"Результат прикладу Y: {resultY:F3}");
    }
}