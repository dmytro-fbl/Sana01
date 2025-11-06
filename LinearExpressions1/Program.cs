internal class Program
{
    private static void Main(string[] args)
    {
        
        bool ok;
        double a, b, c, d, x, resultX, resultY, resultZ, resultR;

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        do
        {
            Console.WriteLine("Введіть число a");
            ok = double.TryParse(Console.ReadLine(), out a);

            if (!ok)
            {
                Console.WriteLine("Помилка, ви ввели не число");
            }
        } while (!ok);
        do
        {
            Console.WriteLine("Введіть число b");
            ok = double.TryParse(Console.ReadLine(), out b);

            if (!ok)
            {
                Console.WriteLine("Помилка, ви ввели не число");
            }
        } while (!ok);
        do
        {
            Console.WriteLine("Введіть число c");
            ok = double.TryParse(Console.ReadLine(), out c);

            if (!ok)
            {
                Console.WriteLine("Помилка, ви ввели не число");
            }
        } while (!ok);
        do
        {
            Console.WriteLine("Введіть число d");
            ok = double.TryParse(Console.ReadLine(), out d);

            if (!ok)
            {
                Console.WriteLine("Помилка, ви ввели не число");
            }
        } while (!ok);
        do
        {
            Console.WriteLine("Введіть число x");
            ok = double.TryParse(Console.ReadLine(), out x);

            if (!ok)
            {
                Console.WriteLine("Помилка, ви ввели не число");
            }
        } while (!ok);

        resultX = ((a + 2 * b - c + d) / c * d) + ((a + b) / (c - d)) - Math.Pow(a, 2) / (Math.Pow(b, 2));

        Console.WriteLine($"Результат Х = {resultX:F3}");
        double oneDil, twoDil;
        oneDil = (5 * (a + b) * (c - d)) / (1.0 / 2 * c);
        twoDil = (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        resultY = oneDil + Math.Pow(d, 2) * twoDil;
        Console.WriteLine($"Результат Y = {resultY:F3}");

        oneDil = Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1);
        twoDil = 5 * a + 3 * b;
        resultZ = (oneDil) * (1 - b) / twoDil;

        Console.WriteLine($"Результат Z = {resultZ:F3}");

        oneDil = 1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5;
        twoDil = 3 * c + 1;
        resultR = oneDil / twoDil + 1 / (a - c);

        Console.WriteLine($"Результат R = {resultR:F3}");
        Console.WriteLine($"Результат R = {a:F3}");

    }
}