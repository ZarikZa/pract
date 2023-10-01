namespace тест_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool m;
            m = true;
            while (m != false)
            {
                Console.WriteLine("Выберите программу 1.Игра Угадай число, 2.Таблица умножения, 3.Вывод делителей числа, 4. Выйти");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    game();
                }
                if (a == "2")
                {
                    table();
                }
                if (a== "3")
                {
                    prog3();
                }
                if (a== "4")
                {
                    Console.WriteLine("пока(");
                    m = false;
                }
            }
        }
        static void game()
        {
            Console.WriteLine("Вы выбрали игра Угадай число");
            Random b = new();
            int c = b.Next(0, 100);
            bool v;
            v = false;
            while (v == false)
            {
                Console.Write("Введите число: ");
                string d = Console.ReadLine();
                int g = Convert.ToInt16(d);
                if (g > c)
                {
                    Console.WriteLine("Введите меньше");
                }
                if (g < c)
                {
                    Console.WriteLine("Введите больше");
                }
                if (g == c)
                {
                    Console.WriteLine("ВЫ ВЫИГРАЛИ УРААА");
                    v = true;
                }
            }
        }
        static void table()
        {
            int[,] n = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] result = new int[10, 10];
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    n[i, j] = j;
                }
            }
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    b[j, i] = j;
                }
            }
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    result[i, j] = n[i, j] * b[i, j];
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void prog3()
        {
            string d = Console.ReadLine();
            int g = Convert.ToInt32(d);
            double h;
            double n;
            int k = g;
            while (k != 0)
            {
                h = g/k;
                n = g%k;
                if (n == 0)
                {
                    Console.WriteLine(k);
                }
                k--;
            }
        }
    }
}